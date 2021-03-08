using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Marathon
{
    public class DBConnection
    {
        static public DataTable dtRunners = new DataTable();
        static public DataTable dtMyRecords = new DataTable();

        static public string TypeSort = "ASC";

        static public string GetEmail = null; //Переменная для получения E-mail юзера при заходе в программу
        static public string GetFirstName = null; //Переменная для получения Имени
        static public string GetLastName = null; //Переменная для получения Фамилии
        static public string Password = null;
        static public string GetGender = null; //Переменная для получения Пола
        static public string GetDateOfBirth = null; //Переменная для получения Даты Рождения
        static public string GetCountryName = null; //Переменная для получения Кода Страны
        static public string GetPhoto = null; //Переменная для получения Фото

        static public string GetKitOptions = null;
        static public string GetContribution = null;
        static public string GetAmountContribution = null;
        static public bool FR = false;
        static public bool SM = false;
        static public bool FM = false;


        static public string GetDonateOrg = null;
        static public string GetTotalDonate = null;
        static public string GetSelectedOption = null;
        static public string GetTypeOfMarathon = null;
        static public string GetRegStatus = null;

        static public string Role = null;

        static MySqlConnection msConnect;
        static MySqlCommand msCommand;
        static public MySqlDataAdapter msDataAdapter;
        static string connectionString = @"Database = up_smirnov;
                                         Data Source = localhost;
                                         UserID = root;
                                         Password = qwerty";
        static public bool Connect()
        {
            try
            {
                msConnect = new MySqlConnection(connectionString);
                msConnect.Open();
                msCommand = new MySqlCommand();
                msCommand.Connection = msConnect;
                msDataAdapter = new MySqlDataAdapter(msCommand);
                return true;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Проверте подключение к базе данных", "Ошибка подключения");
                return false;
            }
        }

        static public void Close()
        {
            msConnect.Close();
        }

        static public void Authorization(string Email, string Password)
        {
            msCommand.CommandText = "SELECT RoleId FROM User WHERE Email = '" + Email + "'AND Password = '" + Password + "';";
            if (msCommand.ExecuteScalar() != null)
            {
                Role = msCommand.ExecuteScalar().ToString();
            }
            else
            {
                Role = null;
            }
        }

        static public void AddUserAndRunner(string Email, string Password, string Name, string Surname, string Gender, string DateOfBirth, string Country, string Photo)
        {
            msCommand.Parameters.AddWithValue("@Photo", Photo);
            msCommand.CommandText = "SELECT email FROM user WHERE email = '" + Email + "'";
            if (msCommand.ExecuteScalar() == null)
            {
                msCommand.CommandText = "INSERT INTO user VALUES ('" + Email + "', '" + Password + "', '" + Name + "', '" + Surname + "', 'R');";
                msCommand.ExecuteNonQuery();
                msCommand.CommandText = "INSERT INTO runner  VALUES (null, '" + Email + "', '" + Gender + "', '" + DateOfBirth + "', '" + Country + "', @Photo)";
                msCommand.ExecuteNonQuery();
                msCommand.Parameters.Clear();
            }
            else
            {
                msCommand.Parameters.Clear();
                System.Windows.Forms.MessageBox.Show("Пользователь с таким E-mail уже зарегестрирован");
            }
        }

        static public void RegOnMarathon(string RaceKitOptionId, string Cost, string CharityId, string SponsorshipTarget)
        {
            msCommand.CommandText = "SELECT RunnerId FROM runner WHERE Email = '" + GetEmail + "'";
            string CurrentUserId = msCommand.ExecuteScalar().ToString();
            msCommand.CommandText = "INSERT INTO registration VAlUES (null, " + CurrentUserId + ", '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + RaceKitOptionId + "',1 , '" + Cost + "', '" + CharityId + "', '" + SponsorshipTarget + "')";
            msCommand.ExecuteNonQuery();
        }

        static public void AddCharity(string SponsorName, string Amount)
        {
            msCommand.CommandText = "SELECT RunnerId FROM runner WHERE Email = '" + GetEmail + "'";
            string RunnerId = msCommand.ExecuteScalar().ToString();
            msCommand.CommandText = "SELECT RegistrationId FROM registration WHERE RunnerId = '" + RunnerId + "'";
            string CurrentUserId = msCommand.ExecuteScalar().ToString();
            msCommand.CommandText = "INSERT INTO sponsorship VAlUES (null, '" + SponsorName + "', '" + CurrentUserId + "', '" + Amount + "')";
            msCommand.ExecuteNonQuery();
        }

        static public void EditUserAndRunner(string Email, string Password, string Name, string Surname, string Gender, string DateOfBirth, string Country, string Photo)
        {
            msCommand.Parameters.AddWithValue("@Photo", Photo);
            if (Email != GetEmail)
            {
                msCommand.CommandText = "UPDATE user SET Email= '" + Email + "', Password= '" + Password + "', FirstName= '" + Name + "', LastName= '" + Surname + "', 'R' WHERE Email = '" + GetEmail + "'";
                msCommand.ExecuteNonQuery();
                msCommand.CommandText = "UPDATE runner  SET Email= '" + Email + "', Gender= '" + Gender + "', DateOfBirth= '" + DateOfBirth + "', CountryCode= '" + Country + "',Photo= @Photo WHERE Email = '" + GetEmail + "'";
            }
            else
            {
                msCommand.CommandText = "UPDATE user SET Password= '" + Password + "', FirstName= '" + Name + "', LastName= '" + Surname + "' WHERE Email = '" + GetEmail + "'";
                msCommand.ExecuteNonQuery();
                msCommand.CommandText = "UPDATE runner  SET Gender= '" + Gender + "', DateOfBirth= '" + DateOfBirth + "', CountryCode= '" + Country + "',Photo= @Photo WHERE Email = '" + GetEmail + "'";
            }
            msCommand.ExecuteNonQuery();
            msCommand.Parameters.Clear();
        }

        static public void EditMarathon(string RaceKitOptionId, string Cost, string Charity, string Contribution)
        {
            msCommand.CommandText = "SELECT RunnerId FROM runner WHERE Email = '" + GetEmail + "'";
            string CurrentUserId = msCommand.ExecuteScalar().ToString();
            msCommand.CommandText = "SELECT RegistrationId FROM registration WHERE RunnerId = '" + CurrentUserId + "'";
            string ID = msCommand.ExecuteScalar().ToString();
            msCommand.CommandText = "UPDATE registration SET RaceKitOptionId = '" + RaceKitOptionId + "', Cost = '" + Cost + "', CharityId = '" + Charity + "', SponsorshipTarget=" + Contribution.Replace(",", ".") + " WHERE RegistrationId = '" + ID + "'";
            msCommand.ExecuteNonQuery();
        }

        static public void EditCharity(string Sponsor, string Amount)
        {
            msCommand.CommandText = "UPDATE sponsorship SET SponsorName = '" + Sponsor + "', Amount='" + Amount.Replace(",", ".") + "' WHERE RegistrationId = '" + GetUserID() + "'";
            msCommand.ExecuteNonQuery();
        }

        //static public string GetCharityName(string SelectedCharityName)
        //{
        //    msCommand.CommandText = "SELECT CharityName FROM charity WHERE CharityName = '" + SelectedCharityName + "'";
        //    return msCommand.ExecuteScalar().ToString();
        //}

        static public string GetCharityDescription(string SelectedCharityID)
        {
            msCommand.CommandText = "SELECT CharityDescription FROM Charity WHERE CharityId = '" + SelectedCharityID + "'";
            return msCommand.ExecuteScalar().ToString();
        }

        static public string GetCharityLogo(string SelectedCharityID)
        {
            msCommand.CommandText = "SELECT CharityLogo FROM Charity WHERE CharityId = '" + SelectedCharityID + "'";
            return msCommand.ExecuteScalar().ToString();
        }

        static public DataTable LoadcmbContribution()
        {
            DataTable Contribution = new DataTable();
            msCommand.CommandText = "SELECT CharityName, CharityId FROM charity ORDER BY CharityId";
            Contribution.Clear();
            msDataAdapter.Fill(Contribution);
            return Contribution;
        }

        static public void GetEdit(string GetEmail)
        {
            msCommand.CommandText = "SELECT FirstName FROM user WHERE Email = '" + GetEmail + "'";
            GetFirstName = msCommand.ExecuteScalar().ToString();
            msCommand.CommandText = "SELECT LastName FROM user WHERE Email = '" + GetEmail + "'";
            GetLastName = msCommand.ExecuteScalar().ToString();
            if (RegForm.Cross == 1)
            {
                msCommand.CommandText = "SELECT Password FROM user WHERE Email = '" + GetEmail + "'";
                Password = msCommand.ExecuteScalar().ToString();
            }
            msCommand.CommandText = "SELECT gender FROM runner WHERE Email = '" + GetEmail + "'";
            GetGender = msCommand.ExecuteScalar().ToString();
            msCommand.CommandText = "SELECT DateOfBirth FROM runner WHERE Email = '" + GetEmail + "'";
            GetDateOfBirth = msCommand.ExecuteScalar().ToString();
            msCommand.CommandText = "SELECT CountryCode FROM runner WHERE Email = '" + GetEmail + "'";
            GetCountryName = msCommand.ExecuteScalar().ToString();
            msCommand.CommandText = "SELECT Photo FROM runner WHERE Email = '" + GetEmail + "'";
            GetPhoto = msCommand.ExecuteScalar().ToString();
        }

        static public void GetEditMarathon(string GetEmail)
        {
            msCommand.CommandText = "SELECT RunnerId FROM runner WHERE Email = '" + GetEmail + "'";
            string RunnerId = msCommand.ExecuteScalar().ToString();

            msCommand.CommandText = "SELECT RaceKitOptionId FROM registration WHERE RunnerId = '" + RunnerId + "'";
            GetKitOptions = msCommand.ExecuteScalar().ToString();
            msCommand.CommandText = "SELECT CharityId FROM registration WHERE RunnerId = '" + RunnerId + "'";
            GetContribution = msCommand.ExecuteScalar().ToString();
            msCommand.CommandText = "SELECT SponsorshipTarget FROM registration WHERE RunnerId = '" + RunnerId + "'";
            GetAmountContribution = msCommand.ExecuteScalar().ToString();
        }

        static public string GetUserID()
        {
            msCommand.CommandText = "SELECT RunnerId FROM runner WHERE Email = '" + GetEmail + "'";
            string CurrentUserId = msCommand.ExecuteScalar().ToString();
            msCommand.CommandText = "SELECT RegistrationId FROM registration WHERE RunnerId = '" + CurrentUserId + "'";
            string UserID;
            return UserID = msCommand.ExecuteScalar().ToString();
        }

        static public void GetMarathon(string GetEmail)
        {
            msCommand.CommandText = "SELECT * FROM registrationevent INNER JOIN event ON registrationevent.EventId = event.EventId WHERE RegistrationId = '" + GetUserID() + "' AND event.EventTypeId = 'FR'";
            if (msCommand.ExecuteScalar() != null)
            {
                FR = true;
            }
            msCommand.CommandText = "SELECT * FROM registrationevent INNER JOIN event ON registrationevent.EventId = event.EventId WHERE RegistrationId = '" + GetUserID() + "' AND event.EventTypeId = 'HM'";
            if (msCommand.ExecuteScalar() != null)
            {
                SM = true;
            }
            msCommand.CommandText = "SELECT * FROM registrationevent INNER JOIN event ON registrationevent.EventId = event.EventId WHERE RegistrationId = '" + GetUserID() + "' AND event.EventTypeId = 'FM'";
            if (msCommand.ExecuteScalar() != null)
            {
                FM = true;
            }
        }

        static public void AddFR()
        {
            msCommand.CommandText = "SELECT EventId FROM registrationevent WHERE EventId = '11_1FR' AND RegistrationId = '" + GetUserID() + "'";
            if (msCommand.ExecuteScalar() == null)
            {
                msCommand.CommandText = "INSERT INTO registrationevent VALUES(null, '" + GetUserID() + "', '11_1FR', null, null)";
                msCommand.ExecuteNonQuery();
            }
        }

        static public void AddHM()
        {
            msCommand.CommandText = "SELECT EventId FROM registrationevent WHERE EventId = '11_1HM' AND RegistrationId = '" + GetUserID() + "'";
            if (msCommand.ExecuteScalar() == null)
            {
                msCommand.CommandText = "INSERT INTO registrationevent VALUES(null, '" + GetUserID() + "', '11_1HM', null, null)";
                msCommand.ExecuteNonQuery();
            }
        }

        static public void AddFM()
        {
            msCommand.CommandText = "SELECT EventId FROM registrationevent WHERE EventId = '11_1FM' AND RegistrationId = '" + GetUserID() + "'";
            if (msCommand.ExecuteScalar() == null)
            {
                msCommand.CommandText = "INSERT INTO registrationevent VALUES(null, '" + GetUserID() + "', '11_1FM', null, null)";
                msCommand.ExecuteNonQuery();
            }
        }

        static public void DeleteFR()
        {
            msCommand.CommandText = "SELECT EventId FROM registrationevent WHERE EventId = '11_1FR' AND RegistrationId = '" + GetUserID() + "'";
            if (msCommand.ExecuteScalar() != null)
            {
                msCommand.CommandText = "DELETE FROM registrationevent WHERE EventId = '11_1FR' AND RegistrationId = '" + GetUserID() + "'";
                msCommand.ExecuteNonQuery();
            }
        }

        static public void DeleteHM()
        {
            msCommand.CommandText = "SELECT EventId FROM registrationevent WHERE EventId = '11_1HM' AND RegistrationId = '" + GetUserID() + "'";
            if (msCommand.ExecuteScalar() != null)
            {
                msCommand.CommandText = "DELETE FROM registrationevent WHERE EventId = '11_1HM' AND RegistrationId = '" + GetUserID() + "'";
                msCommand.ExecuteNonQuery();
            }
        }

        static public void DeleteFM()
        {
            msCommand.CommandText = "SELECT EventId FROM registrationevent WHERE EventId = '11_1FM' AND RegistrationId = '" + GetUserID() + "'";
            if (msCommand.ExecuteScalar() != null)
            {
                msCommand.CommandText = "DELETE FROM registrationevent WHERE EventId = '11_1FM' AND RegistrationId = '" + GetUserID() + "'";
                msCommand.ExecuteNonQuery();
            }
        }

        static public void GetRunners()
        {
            msCommand.CommandText = @"SELECT runner.RunnerId, runner.Email, user.FirstName, user.LastName, runner.Gender, runner.DateOfBirth, runner.CountryCode 
                                      FROM runner, user
                                      WHERE runner.Email = user.Email";
            dtRunners.Clear();
            msDataAdapter.Fill(dtRunners);
        }

        static public void FilterStatus(string Filter)
        {
            msCommand.CommandText = @"SELECT runner.RunnerId, runner.Email, user.FirstName, user.LastName, runner.Gender, runner.DateOfBirth, runner.CountryCode 
                                     FROM runner, user, registration, registrationstatus
                                     WHERE runner.Email = user.Email AND runner.RunnerId = registration.RunnerId AND registrationstatus.RegistrationStatusId = registration.RegistrationStatusId AND RegistrationStatus = '" + Filter + "'";
            dtRunners.Clear();
            msDataAdapter.Fill(dtRunners);
        }

        static public void FilterDistance(string Filter)
        {
            msCommand.CommandText = @"SELECT runner.RunnerId, runner.Email, user.FirstName, user.LastName, runner.Gender, runner.DateOfBirth, runner.CountryCode 
                                      FROM runner, user, registration, registrationevent, event, eventtype
                                      WHERE runner.Email = user.Email AND runner.RunnerId = registration.RunnerId AND registration.RegistrationId = registrationevent.RegistrationId AND registrationevent.EventId = event.EventId AND event.EventTypeId = eventtype.EventTypeId AND EventTypeName = '" + Filter + "'";
            dtRunners.Clear();
            msDataAdapter.Fill(dtRunners);
        }

        static public void FilterStatusAndDistance(string firstFilter, string secondFilter)
        {
            msCommand.CommandText = @"SELECT runner.RunnerId, runner.Email, user.FirstName, user.LastName, runner.Gender, runner.DateOfBirth, runner.CountryCode 
                                     FROM runner, user, registration, registrationstatus, registrationevent, event, eventtype
                                     WHERE runner.Email = user.Email AND runner.RunnerId = registration.RunnerId AND registrationstatus.RegistrationStatusId = registration.RegistrationStatusId AND RegistrationStatus = '" + firstFilter + "' AND registration.RegistrationId = registrationevent.RegistrationId AND registrationevent.EventId = event.EventId AND event.EventTypeId = eventtype.EventTypeId AND EventTypeName = '" + secondFilter + "'";
            dtRunners.Clear();
            msDataAdapter.Fill(dtRunners);
        }

        static public void SortRunner(string Sort, string TypeSort)
        {
            msCommand.CommandText = @"SELECT runner.RunnerId, runner.Email, user.FirstName, user.LastName, runner.Gender, runner.DateOfBirth, runner.CountryCode 
                                      FROM runner, user
                                      WHERE runner.Email = user.Email
                                      ORDER BY " + Sort + " " + TypeSort + "";
            dtRunners.Clear();
            msDataAdapter.Fill(dtRunners);
        }

        static public void SortAndFilterStatus(string Filter, string Sort, string TypeSort)
        {
            msCommand.CommandText = @"SELECT runner.RunnerId, runner.Email, user.FirstName, user.LastName, runner.Gender, runner.DateOfBirth, runner.CountryCode 
                                     FROM runner, user, registration, registrationstatus
                                     WHERE runner.Email = user.Email AND runner.RunnerId = registration.RunnerId AND registrationstatus.RegistrationStatusId = registration.RegistrationStatusId AND RegistrationStatus = '" + Filter + "' ORDER BY " + Sort + " " + TypeSort + "";
            dtRunners.Clear();
            msDataAdapter.Fill(dtRunners);
        }

        static public void SortAndFilterDistance(string Filter, string Sort, string TypeSort)
        {
            msCommand.CommandText = @"SELECT runner.RunnerId, runner.Email, user.FirstName, user.LastName, runner.Gender, runner.DateOfBirth, runner.CountryCode 
                                      FROM runner, user, registration, registrationevent, event, eventtype
                                      WHERE runner.Email = user.Email AND runner.RunnerId = registration.RunnerId AND registration.RegistrationId = registrationevent.RegistrationId AND registrationevent.EventId = event.EventId AND event.EventTypeId = eventtype.EventTypeId AND EventTypeName = '" + Filter + "' ORDER BY " + Sort + " " + TypeSort + "";
            dtRunners.Clear();
            msDataAdapter.Fill(dtRunners);
        }

        static public void SortStatusAndDistance(string firstFilter, string secondFilter, string Sort, string TypeSort)
        {
            msCommand.CommandText = @"SELECT runner.RunnerId, runner.Email, user.FirstName, user.LastName, runner.Gender, runner.DateOfBirth, runner.CountryCode 
                                     FROM runner, user, registration, registrationstatus, registrationevent, event, eventtype
                                     WHERE runner.Email = user.Email AND runner.RunnerId = registration.RunnerId AND registrationstatus.RegistrationStatusId = registration.RegistrationStatusId AND RegistrationStatus = '" + firstFilter + "' AND registration.RegistrationId = registrationevent.RegistrationId AND registrationevent.EventId = event.EventId AND event.EventTypeId = eventtype.EventTypeId AND EventTypeName = '" + secondFilter + "' ORDER BY " + Sort + " " + TypeSort + "";

            dtRunners.Clear();
            msDataAdapter.Fill(dtRunners);
        }

        static public void GetInfoAboutRunner(string GetEmail)
        {
            msCommand.CommandText = "SELECT FirstName FROM user WHERE Email = '" + GetEmail + "'";
            GetFirstName = msCommand.ExecuteScalar().ToString();
            msCommand.CommandText = "SELECT LastName FROM user WHERE Email = '" + GetEmail + "'";
            GetLastName = msCommand.ExecuteScalar().ToString();
            msCommand.CommandText = "SELECT gender FROM runner WHERE Email = '" + GetEmail + "'";
            GetGender = msCommand.ExecuteScalar().ToString();
            msCommand.CommandText = "SELECT DateOfBirth FROM runner WHERE Email = '" + GetEmail + "'";
            GetDateOfBirth = msCommand.ExecuteScalar().ToString();
            msCommand.CommandText = "SELECT CountryCode FROM runner WHERE Email = '" + GetEmail + "'";
            GetCountryName = msCommand.ExecuteScalar().ToString();
            msCommand.CommandText = "SELECT charity.charityname FROM Registration,charity,runner WHERE registration.RunnerId=runner.RunnerId AND Registration.charityid=charity.charityid AND email='" + GetEmail + "'";
            GetDonateOrg = msCommand.ExecuteScalar().ToString();
            msCommand.CommandText = "SELECT sponsorship.Amount FROM sponsorship, registration, Runner WHERE sponsorship.sponsorshipid = registration.SponsorshipTarget AND registration.RunnerId = Runner.RunnerId AND Email = '" + GetEmail + "'";
            GetTotalDonate = msCommand.ExecuteScalar().ToString();
            msCommand.CommandText = "SELECT registration.RaceKitOptionId FROM registration, Runner WHERE registration.RunnerId = Runner.RunnerId AND Email = '" + GetEmail + "'";
            GetSelectedOption = msCommand.ExecuteScalar().ToString();
            msCommand.CommandText = "SELECT Event.EventName FROM event, registrationevent, registration, runner WHERE Event.EventId = registrationevent.EventId AND registrationevent.RegistrationId = registration.RegistrationId AND registration.RunnerId = runner.RunnerId AND Email = '" + GetEmail + "'";
            GetTypeOfMarathon = msCommand.ExecuteScalar().ToString();
            msCommand.CommandText = "SELECT Photo FROM runner WHERE Email = '" + GetEmail + "'";
            GetPhoto = msCommand.ExecuteScalar().ToString();
            msCommand.CommandText = "SELECT registration.RegistrationStatusId FROM registration, Runner WHERE registration.RunnerId = Runner.RunnerId AND Email = '" + GetEmail + "'";
            GetRegStatus = msCommand.ExecuteScalar().ToString();
        }

        static public void GetCertificate(string Email)
        {
            msCommand.CommandText = "SELECT FirstName FROM user WHERE Email = '" + Email + "'";
            PrintCertificate.FirstName = msCommand.ExecuteScalar().ToString();
            msCommand.CommandText = "SELECT LastName FROM user WHERE Email = '" + Email + "'";
            PrintCertificate.SurName = msCommand.ExecuteScalar().ToString();
            if (PrintCertificate.ComboBoxValue == "Full Marathon")
            {
                msCommand.CommandText = "SELECT registrationevent.RaceTime FROM registrationevent, registration, runner, event WHERE registrationevent.RegistrationId = registration.RegistrationId AND registration.RunnerId = runner.RunnerId AND registrationevent.EventId = event.EventId AND EventTypeId = 'FM' AND email = '" + Email + "'";
                PrintCertificate.MyTime = Convert.ToInt16(msCommand.ExecuteScalar());
                msCommand.CommandText = "SELECT COUNT(RaceTime) FROM registrationevent, registration, runner, event WHERE registrationevent.RegistrationId = registration.RegistrationId AND registration.RunnerId = runner.RunnerId AND registrationevent.EventId = event.EventId AND EventTypeId = 'FM' AND email < '" + Email + "'";
                PrintCertificate.MyPlace = Convert.ToInt16(msCommand.ExecuteScalar());
            }
            if (PrintCertificate.ComboBoxValue == "Half Marathon")
            {
                msCommand.CommandText = "SELECT registrationevent.RaceTime FROM registrationevent, registration, runner, event WHERE registrationevent.RegistrationId = registration.RegistrationId AND registration.RunnerId = runner.RunnerId AND registrationevent.EventId = event.EventId AND EventTypeId = 'HM' AND email = '" + Email + "'";
                PrintCertificate.MyTime = Convert.ToInt16(msCommand.ExecuteScalar());
                msCommand.CommandText = "SELECT COUNT(RaceTime) FROM registrationevent, registration, runner, event WHERE registrationevent.RegistrationId = registration.RegistrationId AND registration.RunnerId = runner.RunnerId AND registrationevent.EventId = event.EventId AND EventTypeId = 'FM' AND email < '" + Email + "'";
                PrintCertificate.MyPlace = Convert.ToInt16(msCommand.ExecuteScalar());
            }
            if (PrintCertificate.ComboBoxValue == "5km Fun Run")
            {
                msCommand.CommandText = "SELECT registrationevent.RaceTime FROM registrationevent, registration, runner, event WHERE registrationevent.RegistrationId = registration.RegistrationId AND registration.RunnerId = runner.RunnerId AND registrationevent.EventId = event.EventId AND EventTypeId = 'FR' AND email = '" + Email + "'";
                PrintCertificate.MyTime = Convert.ToInt16(msCommand.ExecuteScalar());
                msCommand.CommandText = "SELECT COUNT(RaceTime) FROM registrationevent, registration, runner, event WHERE registrationevent.RegistrationId = registration.RegistrationId AND registration.RunnerId = runner.RunnerId AND registrationevent.EventId = event.EventId AND EventTypeId = 'FM' AND email < '" + Email + "'";
                PrintCertificate.MyPlace = Convert.ToInt16(msCommand.ExecuteScalar());
            }
            msCommand.CommandText = "SELECT country.CountryName FROM country, runner WHERE country.CountryCode = runner.CountryCode AND Email = '" + Email + "'";
            PrintCertificate.MyCountry = msCommand.ExecuteScalar().ToString();
            msCommand.CommandText = "SELECT registration.SponsorshipTarget FROM registration, runner WHERE registration.RunnerId = runner.RunnerId AND Email = '" + Email + "'";
            PrintCertificate.MyProfit = msCommand.ExecuteScalar().ToString();
        }

        static public void GetDR(string Email)
        {
            msCommand.CommandText = "SELECT runner.DateOfBirth FROM runner WHERE Email = '" + Email + "'";
            MyRecords.DateOfBirth = Convert.ToDateTime(msCommand.ExecuteScalar());
            msCommand.CommandText = "SELECT runner.Gender FROM runner WHERE Email = '" + Email + "'";
            MyRecords.Gender = msCommand.ExecuteScalar().ToString();
        }

        static public void GetMyRecords()
        {
            switch (MyRecords.SwitchMethod)
            {
                case 0:
                    msCommand.CommandText = "SELECT event.EventName, event.EventTypeId, registrationevent.RaceTime " +
                        "FROM registrationevent " +
                        "INNER JOIN event ON registrationevent.EventId = event.EventId " +
                        "INNER JOIN registration ON registrationevent.RegistrationId = registration.RegistrationId " +
                        "INNER JOIN runner ON registration.RunnerId = runner.RunnerId " +
                        "WHERE date_format(runner.DateOfBirth, '%Y') >= year(curdate()) - 18 " +
                        "AND registrationevent.RegistrationId = '" + GetUserID() + "';";
                    msCommand.ExecuteNonQuery();
                    dtMyRecords.Clear();
                    msDataAdapter.Fill(dtMyRecords);
                    break;

                case 1:
                    msCommand.CommandText = "SELECT event.EventName, event.EventTypeId, registrationevent.RaceTime " +
                        "FROM registrationevent " +
                        "INNER JOIN event ON registrationevent.EventId = event.EventId " +
                        "INNER JOIN registration ON registrationevent.RegistrationId = registration.RegistrationId " +
                        "INNER JOIN runner ON registration.RunnerId = runner.RunnerId " +
                        "WHERE date_format(runner.DateOfBirth, '%Y') <= year(curdate()) - 18 " +
                        "AND date_format(runner.DateOfBirth, '%Y') >= year(curdate()) - 29 " +
                        "AND registrationevent.RegistrationId = '" + GetUserID() + "';";
                    msCommand.ExecuteNonQuery();
                    dtMyRecords.Clear();
                    msDataAdapter.Fill(dtMyRecords);
                    break;

                case 2:
                    msCommand.CommandText = "SELECT event.EventName, event.EventTypeId, registrationevent.RaceTime " +
                        "FROM registrationevent " +
                        "INNER JOIN event ON registrationevent.EventId = event.EventId " +
                        "INNER JOIN registration ON registrationevent.RegistrationId = registration.RegistrationId " +
                        "INNER JOIN runner ON registration.RunnerId = runner.RunnerId " +
                        "WHERE date_format(runner.DateOfBirth, '%Y') <= year(curdate()) - 30 " +
                        "AND date_format(runner.DateOfBirth, '%Y') >= year(curdate()) - 39 " +
                        "AND registrationevent.RegistrationId = '" + GetUserID() + "';";
                    msCommand.ExecuteNonQuery();
                    dtMyRecords.Clear();
                    msDataAdapter.Fill(dtMyRecords);
                    break;

                case 3:
                    msCommand.CommandText = "SELECT event.EventName, event.EventTypeId, registrationevent.RaceTime " +
                         "FROM registrationevent " +
                         "INNER JOIN event ON registrationevent.EventId = event.EventId " +
                         "INNER JOIN registration ON registrationevent.RegistrationId = registration.RegistrationId " +
                         "INNER JOIN runner ON registration.RunnerId = runner.RunnerId " +
                         "WHERE date_format(runner.DateOfBirth, '%Y') <= year(curdate()) - 40 " +
                         "AND date_format(runner.DateOfBirth, '%Y') >= year(curdate()) - 55 " +
                         "AND registrationevent.RegistrationId = '" + GetUserID() + "';";
                    msCommand.ExecuteNonQuery();
                    dtMyRecords.Clear();
                    msDataAdapter.Fill(dtMyRecords);
                    break;

                case 4:
                    msCommand.CommandText = "SELECT event.EventName, event.EventTypeId, registrationevent.RaceTime " +
                        "FROM registrationevent " +
                        "INNER JOIN event ON registrationevent.EventId = event.EventId " +
                        "INNER JOIN registration ON registrationevent.RegistrationId = registration.RegistrationId " +
                        "INNER JOIN runner ON registration.RunnerId = runner.RunnerId " +
                        "WHERE date_format(runner.DateOfBirth, '%Y') <= year(curdate()) - 56 " +
                        "AND date_format(runner.DateOfBirth, '%Y') >= year(curdate()) - 70 " +
                        "AND registrationevent.RegistrationId = '" + GetUserID() + "';";
                    msCommand.ExecuteNonQuery();
                    dtMyRecords.Clear();
                    msDataAdapter.Fill(dtMyRecords);
                    break;

                case 5:
                    msCommand.CommandText = "SELECT event.EventName, event.EventTypeId, registrationevent.RaceTime " +
                     "FROM registrationevent " +
                     "INNER JOIN event ON registrationevent.EventId = event.EventId " +
                     "INNER JOIN registration ON registrationevent.RegistrationId = registration.RegistrationId " +
                     "INNER JOIN runner ON registration.RunnerId = runner.RunnerId " +
                     "WHERE date_format(runner.DateOfBirth, '%Y') >= year(curdate()) - 75 " +
                     "AND registrationevent.RegistrationId = '" + GetUserID() + "';";
                    msCommand.ExecuteNonQuery();
                    dtMyRecords.Clear();
                    msDataAdapter.Fill(dtMyRecords);
                    break;
            }
        }
    }
}
