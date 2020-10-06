using System;
using System.CodeDom;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace calculator2
{

    public partial class WebForm1 : System.Web.UI.Page
    {
        static String firstNum;
        static String secondNum;
        static char sign;
        static double calc;
        static bool error = false;
        static String equations = "";
        static int identification;

        static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-58QP3EG\SQL;Initial Catalog=Recall2;Integrated Security=True");
       
       
        
        
        
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSeven_Click(object sender, EventArgs e)
        {
            if (sign == '/' || sign == '*' || sign == '-' || sign == '+' || error == true)
            {
                displayLbl.Text = "";
            }
            displayLbl.Text += "7";
        }
        protected void btnEight_Click(object sender, EventArgs e)
        {
            if (sign == '/' || sign == '*' || sign == '-' || sign == '+' || error == true)
            {
                displayLbl.Text = "";
            }
            displayLbl.Text += "8";
        }
        protected void btnNine_Click(object sender, EventArgs e)
        {
            if (sign == '/' || sign == '*' || sign == '-' || sign == '+' || error == true)
            {
                displayLbl.Text = "";
            }
            displayLbl.Text += "9";
        }
        protected void btnFour_Click(object sender, EventArgs e)
        {
            if (sign == '/' || sign == '*' || sign == '-' || sign == '+' || error == true)
            {
                displayLbl.Text = "";
            }
            displayLbl.Text += "4";
        }
        protected void btnFive_Click(object sender, EventArgs e)
        {
            if (sign == '/' || sign == '*' || sign == '-' || sign == '+' || error == true)
            {
                displayLbl.Text = "";
            }
            displayLbl.Text += "5";
        }
        protected void btnSix_Click(object sender, EventArgs e)
        {
            if (sign == '/' || sign == '*' || sign == '-' || sign == '+' || error == true)
            {
                displayLbl.Text = "";
            }
            displayLbl.Text += "6";
        }
        protected void btnOne_Click(object sender, EventArgs e)
        {
            if (sign == '/' || sign == '*' || sign == '-' || sign == '+' || error == true)
            {
                displayLbl.Text = "";
            }
            displayLbl.Text += "1";
        }
        protected void btnTwo_Click(object sender, EventArgs e)
        {
            if (sign == '/' || sign == '*' || sign == '-' || sign == '+' || error == true)
            {
                displayLbl.Text = "";
            }
            displayLbl.Text += "2";
        }
        protected void btnThree_Click(object sender, EventArgs e)
        {
            if (sign == '/' || sign == '*' || sign == '-' || sign == '+' || error == true)
            {
                displayLbl.Text = "";
            }
            displayLbl.Text += "3";
        }
        protected void btnZero_Click(object sender, EventArgs e)
        {
            if (sign == '/' || sign == '*' || sign == '-' || sign == '+' || error == true)
            {
                displayLbl.Text = "";
            }
            displayLbl.Text += "0";
        }
        protected void btnClear_Click(object sender, EventArgs e)
        {
            displayLbl.Text = "";
            sign = ' ';
            firstNum = "";
            secondNum = "";
            recallLbl.Text = "";
        }
        protected void btnDivide_Click(object sender, EventArgs e)
        {
            firstNum = displayLbl.Text;
            displayLbl.Text = "/";
            sign = '/';
           
            
        }
        protected void btnMultiply_Click(object sender, EventArgs e)
        {
            firstNum = displayLbl.Text;
            displayLbl.Text = "*";
            sign = '*';
        }
        protected void btnMinus_Click(object sender, EventArgs e)
        {
            firstNum = displayLbl.Text;
            displayLbl.Text = "-";
            sign = '-';
            
            
        }
        protected void btnPlus_Click(object sender, EventArgs e)
        {
            firstNum = displayLbl.Text;
            displayLbl.Text = "+";
            sign = '+';
        }
        protected void btnEquals_Click(object sender, EventArgs e)
        {
            secondNum = displayLbl.Text;
            if(secondNum == "0" && sign == '/')
            {
                displayLbl.Text = "Error cannot divide by 0";
                firstNum = "";
                secondNum = "";
                sign = ' ';
                error = true;
            }
            else
            {

                
                switch (sign)
                {
                    case '/':
                        calc = double.Parse(firstNum) / double.Parse(secondNum);
                        break;
                    case '*':
                        calc = double.Parse(firstNum) * double.Parse(secondNum);
                        break;
                    case '-':
                        calc = double.Parse(firstNum) - double.Parse(secondNum);
                        break;
                    case '+':
                        calc = double.Parse(firstNum) + double.Parse(secondNum);
                        break;
                        
                        ;
                }
                equations= firstNum.ToString() + sign.ToString() + secondNum.ToString();
                displayLbl.Text = calc.ToString();

                SqlCommand commI = new SqlCommand("SELECT TOP 1 ID FROM Table_Recall ORDER BY ID DESC;", con);
               try
                {
                    con.Open();
                    SqlDataReader reader = commI.ExecuteReader();
                    while(reader.Read())
                    {
                        var id = reader["ID"].ToString();
                        identification = Int32.Parse(id)+1;
                        
                    }
                }
                catch (SqlException ex)
                {
                    displayLbl.Text = "Error";
                }
                finally
                {
                    con.Close();
                }

                SqlCommand commF = new SqlCommand("INSERT INTO Table_Recall(equation, answer, ID) VALUES(\'"+ equations + "\',\'" + calc + "\'," + identification +");", con);
                try
                {
                    con.Open();
                    commF.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    displayLbl.Text = "Error";
                }
                finally
                {
                    con.Close();
                }





            }
           

        }
       
        protected void btnRecall_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-58QP3EG\SQL;Initial Catalog=Recall2;Integrated Security=True");
            SqlCommand comm = new SqlCommand("SELECT TOP 1 answer FROM Table_Recall ORDER BY ID DESC;", conn);
            SqlCommand commE = new SqlCommand("SELECT TOP 1 equation FROM Table_Recall ORDER BY ID DESC; ", conn);

            
            
            
            

            try
            {
                conn.Open();
                
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    var read = reader["answer"].ToString();
                    displayLbl.Text = read.ToString();
                    
                }
                
            }
            catch (SqlException ex)
            {
                displayLbl.Text = "Error";
            }
            finally
            {
                
                conn.Close();
               
            }
          
            try
            {
                conn.Open();
                SqlDataReader readerE = commE.ExecuteReader();// here seems to be a problem
                while (readerE.Read())
                {
                    var read = readerE["equation"].ToString();
                    recallLbl.Text = read.ToString();
                    
                }
            }
            catch(SqlException dx)
            {
                recallLbl.Text = "Error";
                
            }
            finally
            {
                conn.Close();
            }
         



        }
    }
}
