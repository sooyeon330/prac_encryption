using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prac_encryption
{
    public partial class Form1 : Form
    {
        char[,] board = new char[5, 5];
        static  Boolean oddFlag = false; //글자수 출력
        string zCheck = "";

        string decryption = "";
        string encryption = "";

        string blankCheck = "";
        int blankCheckCount = 0;

        string str = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Btn_en_Click(object sender, EventArgs e)
        {
            str = this.tbx_str.Text;
            setBorad(this.tbx_key.Text);          

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ') //공백제거
                {
                    str = str.Substring(0, i) + str.Substring(i + 1);
                    blankCheckCount++;
                    blankCheck += 10;
                }
                else
                {
                    blankCheck += 0;
                }
                if (str[i] == 'z') //z를 q로 바꿔줘서 처리함.
                {
                    str = str.Substring(0, i) + 'q' + str.Substring(i + 1);
                    zCheck += 1;
                }
                else
                {
                    zCheck += 0;
                }
            }
            encryption = strEncryption(this.tbx_key.Text, str);
            this.lb_enstr.Text = encryption;
            
            for (int i = 0; i < encryption.Length; i++)
            {
                if (encryption[i] == ' ') //공백제거
                    encryption = encryption.Substring(0, i) + encryption.Substring(i + 1);
            }
            
        }

        private  String strEncryption(String key, String str)
        {
            List<char[]> playFair = new List<char[]>();
            List<char[]> encPlayFair = new List<char[]>();
            int x1 = 0, x2 = 0, y1 = 0, y2 = 0;
            String encStr = "";

            for (int i = 0; i < str.Length; i += 2) // arraylist 세팅
            {
                char[] tmpArr = new char[2];
                tmpArr[0] = str[i];
                try
                {
                    if (str[i] == str[i + 1]) //글이 반복되면 x추가
                    {
                        tmpArr[1] = 'x';
                        i--;
                    }
                    else
                    {
                        tmpArr[1] = str[i+1];
                    }
                }
                catch (IndexOutOfRangeException e)
                {
                    tmpArr[1] = 'x';
                    oddFlag = true;
                }
                playFair.Add(tmpArr);
            }

            for (int i = 0; i < playFair.Count; i++)
            {
                this.lb_enstr.Text += playFair[i][0] + "" + playFair[i][1] + " ";
            }


            for (int i = 0; i < playFair.Count; i++)
            {

                char[] tmpArr = new char[2];
                for (int j = 0; j < 5; j++) //쌍자암호의 각각 위치체크
                {
                    for (int k = 0; k < 5; k++)
                    {
                        if (board[j, k] == playFair[i][0])
                        {
                            x1 = j;
                            y1 = k;
                        }
                        if (board[j,k] == playFair[i][1])
                        {
                            x2 = j;
                            y2 = k;
                        }
                    }
                }


                if (x1 == x2) //행이 같은경우
                {
                    tmpArr[0] = board[x1, (y1 + 1) % 5];
                    tmpArr[1] = board[x2, (y2 + 1) % 5];
                }
                else if (y1 == y2) //열이 같은 경우
                {
                    tmpArr[0] = board[(x1 + 1) % 5, y1];
                    tmpArr[1] = board[(x2 + 1) % 5, y2];
                }
                else //행, 열 모두 다른경우
                {
                    tmpArr[0] = board[x2, y1];
                    tmpArr[1] = board[x1, y2];
                }

                encPlayFair.Add(tmpArr);

            }

            for (int i = 0; i < encPlayFair.Count; i++)
            {
                encStr += encPlayFair[i][0] + "" + encPlayFair[i][1] + " ";
            }


            return encStr;
        }
        private  String strDecryption(String key, String str, String zCheck)
        {
            List<char[]> playFair = new List<char[]>(); //바꾸기 전 쌍자암호를 저장할 곳
            List<char[]> decPlayFair = new List<char[]>(); //바꾼 후의 쌍자암호 저장할 곳
            int x1 = 0, x2 = 0, y1 = 0, y2 = 0; //쌍자 암호 두 글자의 각각의 행,열 값
            String decStr = "";

            int lengthOddFlag = 1;
            

            for (int i = 0; i < str.Length; i += 2)
            {
                char[] tmpArr = new char[2];
                tmpArr[0] = str[i];
                tmpArr[1] = str[i+1];
                this.lb_enstr.Text += str;
                playFair.Add(tmpArr);
         //       this.lb_enstr.Text += tmpArr[0].ToString()+tmpArr[1].ToString();
            }

            

            for (int i = 0; i < playFair.Count; i++)
            {

                char[] tmpArr = new char[2];
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        if (board[j,k] == playFair[i][0])
                        {
                            x1 = j;
                            y1 = k;
                            this.lb_enstr.Text += x1+","+y1+"  ";
                        }
                        if (board[j,k] == playFair[i][1])
                        {
                            x2 = j;
                            y2 = k;
                            this.lb_enstr.Text += x1 + "," + y1+"  ";
                        }
                    }
                }

                if (x1 == x2) //행이 같은 경우 각각 바로 아래열 대입
                {
                    tmpArr[0] = board[x1 ,(y1 + 4) % 5];
                    tmpArr[1] = board[x2 ,(y2 + 4) % 5];
                   
                }
                else if (y1 == y2) //열이 같은 경우 각각 바로 옆 열 대입
                {
                    tmpArr[0] = board[(x1 + 4) % 5, y1];
                    tmpArr[1] = board[(x2 + 4) % 5, y2];
                }
                else //행, 열 다른경우 각자 대각선에 있는 곳.
                {
                    tmpArr[0] = board[x2, y1];
                    tmpArr[1] = board[x1, y2];
                }
              
                decPlayFair.Add(tmpArr);

            }

            for (int i = 0; i < decPlayFair.Count; i++) //중복 문자열 돌려놓음
            {
                if (i != decPlayFair.Count-1 && decPlayFair[i][1] == 'x'
                        && decPlayFair[i][0] == decPlayFair[i+1][0])
                {
                    decStr += decPlayFair[i][0];
                }
                else
                {
                    decStr += decPlayFair[i][0] + "" + decPlayFair[i][1];
                }
            }



            for (int i = 0; i < zCheck.Length; i++)//z위치 찾아서 q로 돌려놓음
            {
                if (zCheck[i] == '1')
                    decStr = decStr.Substring(0, i) + 'z' + decStr.Substring(i + 1);

            }



            if (oddFlag) decStr = decStr.Substring(0,decStr.Length-1);

            /*
             //띄어쓰기
            for(int i = 0 ; i < decStr.Length; i++)
            {
                if(i%2==lengthOddFlag){
                    decStr = decStr.Substring(0, i+1)+" "+decStr.Substring(i+1);
                    i++;
                    lengthOddFlag = ++lengthOddFlag %2;
                }
            }
            */
            return decStr;
        }
        private void setBorad(string key)
        {
            this.lb_table.Text = "";
            string keyForset = "";
            Boolean overlapFlag = false;
            int keylenghtCount = 0;

            key += "abcdefghijklmnopqrstuvwxyz";

            // 중복처리
            for (int i = 0; i < key.Length; i++)
            {
                for (int j = 0; j < keyForset.Length; j++)
                {
                    if (key[i] == keyForset[j])
                    {
                        overlapFlag = true;
                        break;
                    }
                }
                if (!(overlapFlag)) keyForset += key[i];
                overlapFlag = false;
            }

            //배열에 대입
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    board[i, j] = keyForset[keylenghtCount++];
                }
            }

            //배열출력
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    this.lb_table.Text += board[i, j] + " - ";
                }
                this.lb_table.Text += "\n";
            }

        }

        private void Btn_de_Click(object sender, EventArgs e)
        {
            decryption = strDecryption(this.tbx_key.Text, encryption, zCheck);
            //ok
            
            for (int i = 0; i < decryption.Length; i++)
            {
                //    if (blankCheckCount > 0)
                //    {
                try
                {
                    if (blankCheck[i] == '1')
                    {
                        decryption = decryption.Substring(0, i) + " " + decryption.Substring(i);
                    }
                }catch(Exception ex)
                {
                    
                }
                finally
                {
                   
                }
               //     }
            }
            
            this.lb_destr.Text = decryption;
        }
    }
}
