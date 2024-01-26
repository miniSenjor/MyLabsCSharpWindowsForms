using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace lr17
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        public int Score = 0;
        Question[] masQue =
        {
            new Question("Какой сейчас год?", 1, "2023", "2000", "2001", "2023", "2030"),
            new Question("Какой ты Жебраков?", 2, "ДомашнийЖеброни", "Домашний", "Новогодний", "Жеброни", "ЖБР"),
            new Question("...эруэхи", 3, "айдихи"),
            new Question("Какой сейчас год?", 3, "2023"),
            new Question("Слово пацана?", 1, "Слово пацана", "Я чушпан", "Слово пацана", "Уээ","Кто это?"),
            new Question("Лучший преподаватель?", 2, "Все", "Semen", "Куст", "Жеб","Все"),
            new Question("Чайный властелин?", 1, "Платон Антонтников", "Не знаю", "Платон Антонтников", "Я","ЖБР"),
            new Question("Советник из цивки?", 3, "Лукина"),
            new Question("Я?", 1, "Молодец", "Молдец", "Чушпан", "Я","ЖБР"),
            new Question("Чайный властелин?", 1, "Платон Антонтников", "Не знаю", "Платон Антонтников", "Я","ЖБР"),
            new Question("Чайный властелин?", 1, "Платон Антонтников", "Не знаю", "Платон Антонтников", "Я","ЖБР"),
            new Question("Чайный властелин?", 1, "Платон Антонтников", "Не знаю", "Платон Антонтников", "Я","ЖБР"),
            new Question("Чайный властелин?", 1, "Платон Антонтников", "Не знаю", "Платон Антонтников", "Я","ЖБР"),
            new Question("Чайный властелин?", 1, "Платон Антонтников", "Не знаю", "Платон Антонтников", "Я","ЖБР"),
            new Question("Чайный властелин?", 1, "Платон Антонтников", "Не знаю", "Платон Антонтников", "Я","ЖБР"),
            new Question("Чайный властелин?", 1, "Платон Антонтников", "Не знаю", "Платон Антонтников", "Я","ЖБР"),
            new Question("Чайный властелин?", 1, "Платон Антонтников", "Не знаю", "Платон Антонтников", "Я","ЖБР"),
            new Question("Чайный властелин?", 1, "Платон Антонтников", "Не знаю", "Платон Антонтников", "Я","ЖБР"),
            new Question("Чайный властелин?", 1, "Платон Антонтников", "Не знаю", "Платон Антонтников", "Я","ЖБР"),
            new Question("Чайный властелин?", 1, "Платон Антонтников", "Не знаю", "Платон Антонтников", "Я","ЖБР"),
        };

        public int Number = 0;

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Number > 0)
                Check(Number-1, masQue[Number-1].typ);
            if (Number < masQue.Length)
            {
                lblQuest.Text = Number+1+")"+masQue[Number].quest;
                switch (masQue[Number].typ)
                {
                    case 1:
                        {
                            panel1.Visible = true;
                            panel2.Visible = false;
                            panel3.Visible = false;
                            panel4.Visible = false;
                            rdBtn1.Text = masQue[Number].answ1;
                            rdBtn2.Text = masQue[Number].answ2;
                            rdBtn3.Text = masQue[Number].answ3;
                            rdBtn4.Text = masQue[Number].answ4;

                        }
                        break;
                    case 2:
                        {
                            panel1.Visible = false;
                            panel2.Visible = true;
                            panel3.Visible = false;
                            panel4.Visible = false;
                            chBx1.Text = masQue[Number].answ1;
                            chBx2.Text = masQue[Number].answ2;
                            chBx3.Text = masQue[Number].answ3;
                            chBx4.Text = masQue[Number].answ4;
                        }
                        break;
                    case 3:
                        {
                            panel1.Visible = false;
                            panel2.Visible = false;
                            panel3.Visible = true;
                            panel4.Visible = false;
                        }
                        break;
                }
                
            }
            Number++;
            if (Number > masQue.Length)
            {
                if (!File.Exists("Result.txt"))
                    File.Create("Result.txt");
                using (StreamWriter sw = File.AppendText("Result.txt"))
                {
                    sw.WriteLine(Name+" "+Score);
                }
                Close();
            }
            
        }

        private void Test_Load(object sender, EventArgs e)
        {
            this.Width = 320;
            this.Height = 270;
            btnNext.Visible = false;
            panelName.Location = new Point(50, 60);
            panelName.Visible = true;
            panel1.Location = new Point(50, 30);
            panel2.Location = new Point(50, 30);
            panel3.Location = new Point(50, 30);
            panel4.Location = new Point(50, 30);
            btnNext.Location = new Point(140,200);
        }

        private void Check(int i, int type)
        {
            switch(type)
            {
                case 1:
                    {
                        /*foreach (var radioButton in Controls.OfType<System.Windows.Forms.RadioButton>())
                        {
                            if (radioButton.Checked)
                            {
                                if (radioButton.Text == masQue[i].rigthAnsw)
                                    Score++;
                                break;
                            }
                        }*/
                        if (rdBtn1.Checked)
                        {
                            if (rdBtn1.Text == masQue[i].rigthAnsw)
                                Score++;
                        }
                        else if(rdBtn2.Checked)
                        {
                            if (rdBtn2.Text == masQue[i].rigthAnsw)
                                Score++;
                        }
                        else if (rdBtn3.Checked)
                        {
                            if (rdBtn3.Text == masQue[i].rigthAnsw)
                                Score++;
                        } 
                        else
                        {
                            if (rdBtn4.Text == masQue[i].rigthAnsw)
                                Score++;
                        }

                    }
                    break;
                case 2:
                    {
                        string answer = "";
                        /*foreach (System.Windows.Forms.CheckBox checkBox in Controls.OfType<System.Windows.Forms.CheckBox>())
                        {
                            if (checkBox.Checked)
                            {
                                answer += checkBox.Text;
                            }
                        }
                        if (answer == masQue[i].rigthAnsw) 
                            Score++;*/
                        if (chBx1.Checked)
                        {
                            answer+=chBx1.Text;
                        }
                        else if (chBx2.Checked)
                        {
                            answer+=chBx2.Text;
                        }
                        else if (chBx3.Checked)
                        {
                            answer+=chBx3.Text;
                        }
                        else
                        {
                            answer += chBx4.Text;
                        }
                        if (answer == masQue[Number].rigthAnsw)
                            Score++;
                    }
                    break;
                case 3:
                    {
                    if (txtAnswer.Text == masQue[i].rigthAnsw)
                        Score++;
                        txtAnswer.Text = "";
                    }
                    break;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Name = txtNameFirst.Text;
            panelName.Visible = false;
            btnNext.Visible = true;
            btnNext_Click(sender, e);
        }
    }

    class Question
    {
        public string quest;
        public int typ;
        public string rigthAnsw;
        public string answ1;
        public string answ2;
        public string answ3;
        public string answ4;

        public Question(string question, int type, string rigthAnswer, string answer1 = "", string answer2 = "", string answer3 = "", string answer4 = "")
        {
            quest = question;
            typ = type;
            rigthAnsw = rigthAnswer;
            answ1 = answer1;
            answ2 = answer2;
            answ3 = answer3;
            answ4 = answer4;
        }
    }
}
