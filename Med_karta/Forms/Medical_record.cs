using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Med_karta.Data;

namespace Med_karta.Forms
{
    public partial class Medical_record : Form
    {
        public Medical_record()
        {
            InitializeComponent();

            //привязка событий
            _buttonAddPatient.Click += Button_AddPatien_Click;
            _comBoxEmployment.TextChanged += Eployment_TextChanged;
            _buttonResearches.Click += ButtonResearches_Click;
            this.FormClosed += From_Closed;
            this.Load += Medical_record_Load;
        }

        private void Medical_record_Load(object sender, EventArgs e)
        {
            //DataContext data = new DataContext();

            //string com = "INSERT INTO Личные_данные ( Пользователь ) SELECT [Пользователи].[ID] AS Выражение1 FROM Пользователи;";

            //OleDbCommand comm = new OleDbCommand(com, data.getConnection());

            //data.Connection();

            //comm.Parameters.Add("Личные_данные.[Пользователь]", OleDbType.Integer);
            //comm.ExecuteNonQuery();

            //data.Disconnection();
        }

        private void From_Closed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void ButtonResearches_Click(object sender, EventArgs e)
        {
            if (!_mainPanel.AutoScroll)
            {
                _mainPanel.AutoScroll = true;
            }
            else
                _mainPanel.AutoScroll = false;
            
        }

        private void Eployment_TextChanged(object sender, EventArgs e)
        {
           if(_comBoxEmployment.SelectedIndex == 0)
            {
                _txtPlaceOfWork.Text = null;
                _txtPlaceOfWork.Enabled = true;
            }
            else
            {
                _txtPlaceOfWork.Text = "Нет";
                _txtPlaceOfWork.Enabled = false;
            }
        }

        // Кнопка на добавление Пациентов
        private void Button_AddPatien_Click(object sender, EventArgs e)
        {
            DataContext dc = new DataContext();

            String LastName = _txtLastName.Text;
            String FirstName = _txtFirstName.Text;
            String Patronymic = _txtPatronymic.Text;
            String DateOfBirth = _dateOfBirth.Text;
            String Phone = _txtPhone.Text;
            String Sex = _comBoxSex.Text;
            String MaritalStats = _comBoxMaritalStat.Text;
            String Education = _comBoxEducation.Text;
            String Employment = _comBoxEmployment.Text;
            String PlaceOfWork = _txtPlaceOfWork.Text;
            String Disability = _comBoxDisability.Text;
            String Area = _txtArea.Text;
            String Sity = _txtSity.Text;
            String HumanStattlement = _txtHumanSettlement.Text;
            String Street = _txtStreet.Text;
            String Home = _txtHome.Text;
            String Flat = _txtFlat.Text;
            String Terrain = _txtTerrain.Text;
            String PolisOMS = _txtPolisOMS.Text;
            String SNILS = _txtSNILS.Text;
            String Document = _txtDocument.Text;

            string Str_command = "INSERT INTO `Личные_данные` (`Фамилия`,`Имя`,`Отчество`," +
                "`Дата_рождения`,`Телефон`,`Пол`,`Семейное_положение`,`Образование`,`Занятость`,`Инвалидность`,`Место_работы`," +
                "`Район`,`Город`,`Населенный_пункт`,`Улица`,`Дом`,`Квартира`,`Местность`," +
                "`Полис_ОМС`,`Снилс`,`Документ`) VALUES (@LName,@FName,@Patr,@Date,@Phone,@Sex,@MtlSts," +
                "@Educ,@Epl,@Disab,@Work,@Area,@Sity,@HumStat,@Street,@Hom,@Flat,@Terr,@Polis,@Snils,@Doc)";

//            string commm = "INSERT INTO Личные_данные ( Пользователь, Фамилия, Имя, Отчество," +
// "Дата_рождения, Телефон, Пол, Семейное_положение, Образование, Занятость, Инвалидность, Место_работы, Район, Город, Населенный_пункт, Улица, Дом, Квартира, Местность, Полис_ОМС, Снилс, Документ) SELECT Пользователи.ID AS Выражение1, `@LName` AS Выражение2, `@FName` AS Выражение3, `@Patr` AS Выражение4, `@Date` AS Выражение5, `@Phone` AS Выражение6," +
//"`@Sex` AS Выражение7, `@MtlSts` AS Выражение8, `@Educ` AS Выражение9, `@Epl` AS Выражение10, `@Disab` AS Выражение11, `@Work` AS Выражение12, `@Area` AS Выражение13, `@Sity` AS Выражение14," +
// "`@HumStat` AS Выражение15, `@Street` AS Выражение16, `@Hom` AS Выражение17, `@Flat` AS Выражение18, `@Terr` AS Выражение19, `@Polis` AS Выражение20, `@Snils` AS Выражение21, `@Doc` AS Выражение22" +
//"FROM Пользователи";
            

            OleDbCommand command = new OleDbCommand(Str_command, dc.getConnection());

            command.Parameters.Add("@LName", OleDbType.VarChar).Value = LastName;
            command.Parameters.Add("@FName", OleDbType.VarChar).Value = FirstName;
            command.Parameters.Add("@Patr", OleDbType.VarChar).Value = Patronymic;
            command.Parameters.Add("@Date", OleDbType.Date).Value = DateOfBirth;
            command.Parameters.Add("@Phone", OleDbType.VarChar).Value = Phone;
            command.Parameters.Add("@Sex", OleDbType.VarChar).Value = Sex;
            command.Parameters.Add("@MtlSts", OleDbType.VarChar).Value = MaritalStats;
            command.Parameters.Add("@Educ", OleDbType.VarChar).Value = Education;
            command.Parameters.Add("@Epl", OleDbType.VarChar).Value = Employment;
            command.Parameters.Add("@Work", OleDbType.VarChar).Value = PlaceOfWork;
            command.Parameters.Add("@Disab", OleDbType.VarChar).Value = Disability;
            command.Parameters.Add("@Area", OleDbType.VarChar).Value = Area;
            command.Parameters.Add("@Sity", OleDbType.VarChar).Value = Sity;
            command.Parameters.Add("@HumStat", OleDbType.VarChar).Value = HumanStattlement;
            command.Parameters.Add("@Street", OleDbType.VarChar).Value = Street;
            command.Parameters.Add("@Hom", OleDbType.Integer).Value = Home;
            command.Parameters.Add("@Flat", OleDbType.Integer).Value = Flat;
            command.Parameters.Add("@Terr", OleDbType.VarChar).Value = Terrain;
            command.Parameters.Add("@Polis", OleDbType.VarChar).Value = PolisOMS;
            command.Parameters.Add("@Snils", OleDbType.VarChar).Value = SNILS;
            command.Parameters.Add("@Doc", OleDbType.VarChar).Value = Document;
            

            dc.Connection();
            
            if (!CheckNullTxtBox())
            {
                MessageBox.Show("Не все значения введенны", "Введите значение!");
            }
            else
            {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Данные успешно добавлены");
                    }
                    else
                    {
                        MessageBox.Show("Ошибка данные не добавлены");
                    }
            }
            dc.Disconnection();

           
        }

        private bool CheckNullTxtBox()
        {
            if (String.IsNullOrEmpty(_txtLastName.Text) && String.IsNullOrEmpty(_txtFirstName.Text) && String.IsNullOrEmpty(_txtPatronymic.Text) &&
                String.IsNullOrEmpty(_txtPhone.Text) && String.IsNullOrEmpty(_comBoxSex.Text) && String.IsNullOrEmpty(_comBoxMaritalStat.Text) &&
                String.IsNullOrEmpty(_comBoxEducation.Text) && String.IsNullOrEmpty(_comBoxEmployment.Text) && String.IsNullOrEmpty(_comBoxDisability.Text) &&
                String.IsNullOrEmpty(_txtArea.Text) && String.IsNullOrEmpty(_txtSity.Text) && String.IsNullOrEmpty(_txtHumanSettlement.Text) &&
                String.IsNullOrEmpty(_txtStreet.Text) && String.IsNullOrEmpty(_txtHome.Text) && String.IsNullOrEmpty(_txtFlat.Text) && String.IsNullOrEmpty(_txtTerrain.Text) &&
                String.IsNullOrEmpty(_txtPolisOMS.Text) && String.IsNullOrEmpty(_txtSNILS.Text) && String.IsNullOrEmpty(_txtDocument.Text))
            {
                return false;
            }
            else
                return true;

          
        }
    }
}
