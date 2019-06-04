using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Plusik
{

    public partial class Plusik : Form
    {
        public Random rnd = new Random();
        int goal;               // число, которое нужно набрать
        int currentNumber;      // текущее число 
        int steps;              // минимальное количество шагов    
        int currentSteps;       // текущее количество шагов
        List<Player> playersList = new List<Player>();

        public Plusik()
        {
            InitializeComponent();
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void Plusik_Load(object sender, EventArgs e)
        {                       
            labelLogin.Text = LoginForm.login;
            FileRead();
            Restart();
        }
        
        #region Game Logical

        private void Restart()
        {                       
            goal = rnd.Next(10, 250);
            labelGoal.Text = Convert.ToString(goal);
            currentNumber = 1;
            labelCurrent.Text = "1";
            steps = GetSteps(goal);
            currentSteps = 0;
            labelStepsCount.Text = "0";
        }

        //Функция подсчёта минимального колличества шагов
        private int GetSteps(int a)
        {
            int s = 0;
            while (a != 1)
            {
                if (a % 2 == 0) {a /= 2; s++;}
                else {a--; s++;}
            }
            return s;
        }

        //Проверка текущего числа
        private void Check()     
        {                        
            if (currentNumber > goal)
            {
                MessageBox.Show("LOOSER");
                Restart();
            }
            if (currentNumber == goal)
            {
                if (currentSteps == steps)
                {
                    Win();
                    MessageBox.Show("KRACUBO");
                    Restart();
                }
                else
                {
                    MessageBox.Show("NEKRACUBO");
                    Restart();
                }
            }
        }

        //Проверка введенного числа
        private bool IdiotCheck()
        {
            if (textBoxSetNumber.Text == "" || textBoxSetNumber.Text == "0" || textBoxSetNumber.Text == "1")
            {
                return false;
            }
            if (textBoxSetNumber.Text.Length > 5)
            {
                return false;
            }
            for (int i = 0; i < textBoxSetNumber.Text.Length; i++)
            {
                if (textBoxSetNumber.Text[i] < '0' || textBoxSetNumber.Text[i] > '9')
                {
                    return false;
                }
            }
            return true;
        }

        //Функция победы
        private void Win()
        {
            for (int i = 0; i < playersList.Count; i++)
            {
                if (playersList[i].name == labelLogin.Text)
                {
                    playersList[i].score += 1;
                    playersList.Sort();
                    break;
                }
            }
        }

        private void FileRead()
        {
            StreamReader sr = new StreamReader("score.txt");
            string s = sr.ReadLine();
            while (s != "STOP")
            {
                string[] str = s.Split();
                Player p = new Player(str[0], Convert.ToInt32(str[1]));
                playersList.Add(p);
                s = sr.ReadLine();
            }
            sr.Close();
            playersList.Sort();
            for (int i = 0; i < playersList.Count; i++)
            {
                if (playersList[i].name == labelLogin.Text)
                    return;
            }
            playersList.Add(new Player(labelLogin.Text, 0));
        }

        #endregion

        #region Buttons

        //Операция "+1"
        private void summ_Click(object sender, EventArgs e)
        {
            currentNumber++;
            labelCurrent.Text = Convert.ToString(currentNumber);
            currentSteps++;
            labelStepsCount.Text = Convert.ToString(currentSteps);
            Check();
        }

        //Операция "*2"
        private void mult_Click(object sender, EventArgs e) 
        {
            currentNumber *= 2;
            labelCurrent.Text = Convert.ToString(currentNumber);
            currentSteps++;
            labelStepsCount.Text = Convert.ToString(currentSteps);
            Check();                 // проверка числа
        }

        //Создание рандомного числа
        private void buttonRandom_Click(object sender, EventArgs e)
        {
            Restart();
        }

        //Чтение введенного числа
        private void ButtonSetNumber_Click(object sender, EventArgs e)
        {
            // задать число вручную
            if (IdiotCheck())
            {
                goal = int.Parse(textBoxSetNumber.Text);
                currentNumber = 1;
                labelCurrent.Text = "1";
                labelGoal.Text = textBoxSetNumber.Text;
                steps = GetSteps(goal);
                currentSteps = 0;
            }
            textBoxSetNumber.Text = "";
        }

        private void textBoxSetNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (IdiotCheck())
                {
                    goal = int.Parse(textBoxSetNumber.Text);
                    currentNumber = 1;
                    labelCurrent.Text = "1";
                    labelGoal.Text = textBoxSetNumber.Text;
                    steps = GetSteps(goal);
                    currentSteps = 0;
                }
                textBoxSetNumber.Text = "";
            }
        }

        #endregion

        #region Game menu

        //Перерегистрация
        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
            labelLogin.Text = LoginForm.login;
        }

        //Вывод статистики текущего игрока
        private void statsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < playersList.Count; i++)
            {
                if (playersList[i].name == labelLogin.Text)
                    MessageBox.Show(playersList[i].name + " " + playersList[i].score.ToString());
            }

        }

        //Вывод полного рейтинга
        private void ratingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = "";
            int n;
            if (playersList.Count < 10)
                n = playersList.Count;
            else n = 10;
            for (int i = 0; i < n; i++)
            {
                str += playersList[i].name + " " + playersList[i].score.ToString() + "\n";
            }
            MessageBox.Show(str);
        }

        //Выход и сохранение файла
        private void SaveandcloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("score.txt");
            for (int i = 0; i < playersList.Count; i++)
            {
                sw.WriteLine(playersList[i].name + " " + playersList[i].score);
            }
            sw.Write("STOP");
            sw.Close();
            this.Close();
        }
        
        //Справка
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgramm AB = new AboutProgramm();
            AB.ShowDialog();
        }

        #endregion
    }

    class Player : IComparable<Player>
    {
        public string name;
        public int score;

        public Player(string str, int n)
        {
            name = str;
            score = n;
        }

        public int CompareTo(Player other)
        {
            if (score == other.score)
                return 0;
            if (score < other.score)
                return 1;
            else return -1;
        }
    }
}
