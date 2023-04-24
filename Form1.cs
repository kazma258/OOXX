using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace OOXX
{
	public partial class Form1 : Form
	{
		int[,] arr = new int[3, 3];
		int spacePos = -1; // 定義空位置
		string codePath = (AppDomain.CurrentDomain.BaseDirectory) + "..\\..\\";
		List<Button> buttonList = new List<Button>();
		Image xPath, oPath;
		Image npc_img, player_img;
		public Form1()
		{
			InitializeComponent();
			//MessageBox.Show(AppDomain.CurrentDomain.BaseDirectory);
			buttonList.Add(button_00);
			buttonList.Add(button_01);
			buttonList.Add(button_02);
			buttonList.Add(button_10);
			buttonList.Add(button_11);
			buttonList.Add(button_12);
			buttonList.Add(button_20);
			buttonList.Add(button_21);
			buttonList.Add(button_22);
            foreach (var item in buttonList)
            {
				item.Enabled = false;
            }
            //CheckPathExists();
            xPath = Image.FromFile(codePath + "Img/img_X.jpg");
			oPath = Image.FromFile(codePath + "Img/img_O.jpg");
			CheckPathExists();
			npc_img = oPath;
			player_img = xPath;
		}

		private void startGame_Click(object sender, EventArgs e)
		{
			foreach (var btn in buttonList)
			{
				btn.Image = null;
				btn.Enabled = true;
				for (int i = 0; i < 3; i++)
				{
					for (int j = 0; j < 3; j++)
					{
						arr[i, j] = spacePos;
					}
				}
			}
			if (radioButton2.Checked)
			{
				NpcPlay();
			}
		}

		private void StopApp_Click(object sender, EventArgs e)
		{
			// stop application
			Process.GetCurrentProcess().Kill();
		}

		private void GameButton_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			// let player_img size fit button size
			player_img = new Bitmap(player_img, btn.Width, btn.Height);
			btn.Image = player_img;
			btn.Enabled = false;
			string pos = btn.Name.Substring(btn.Name.Length - 2, 2);
			Debug.WriteLine("pos index: " + pos);
			// 設定玩家參數為1
			arr[Convert.ToInt32(pos[0] - '0'), Convert.ToInt32(pos[1] - '0')] = 1;
			CheckWin(true);
			// 電腦下棋
			NpcPlay();
			CheckWin(false);
		}
		private bool NpcPlay()
		{
			if (arr[1,1] == spacePos)
			{
				NpcAction(1, 1);
				return true;
			}
			// 尋找電腦快勝利的格子
			for(int i  = 0; i < 3; i++)
			{
				int chkrow = 0;
				if (arr[0, i] + arr[1, i] + arr[2, i] == 3)
				{
					for (int j = i; j < 3; j++)
					{
						if (arr[j, i] == spacePos)
						{
							NpcAction(j, i);
							return true;
						}
					}
				}
				for (int j = 0; j < 3; j++)
				{
					if (arr[i, j] == 2)
						chkrow++;
				}
				if (chkrow == 2)
				{
					for (int j = 0; j < 3; j++)
					{
						if (arr[i, j] == spacePos)
						{
							NpcAction(i, j);
							return true;
						}
					}
				}
			}
			if (arr[0, 0] + arr[1, 1] + arr[2, 2] == 3)
			{
				for (int i = 0; i < 3; i++)
					if (arr[i, i] == spacePos)
						NpcAction(i, i);
				return true;
			}
			if (arr[2, 0] + arr[1, 1] + arr[0, 2] == 3)
			{
				for (int i = 0; i < 3; i++)
					if (arr[2 - i, i] == spacePos)
						NpcAction(2-i, i);
				return true;
			}
			// 尋找玩家快勝利的格子
			for (int i = 0; i < 3; i++)
			{
				int chkrow = 0;
				if (arr[0, i] + arr[1, i] + arr[2, i] == 1)
				{
					for(int j = 0; j< 3; j++)
					{
						if (arr[j, i] == spacePos)
						{
							NpcAction(j, i);
							return true;
						}
					}
				}
				for (int j = 0; j < 3; j++)
				{
					if (arr[i, j] == 1)
						chkrow++;
				}
				if(chkrow == 2)
				{
					for( int j = 0; j< 3; j++)
					{
						if (arr[i, j] == spacePos)
						{
							NpcAction(i, j);
							return true;
						}
					}
				}
			}
			if (arr[0, 0] + arr[1, 1] + arr[2, 2] == 1)
			{
				for (int i = 0; i < 3; i++)
					if (arr[i, i] == spacePos)
						NpcAction(i, i);
				return true;
			}
			if (arr[2, 0] + arr[1, 1] + arr[0, 2] == 1)
			{
				for (int i = 0; i < 3; i++)
					if (arr[2 - i, i] == spacePos)
						NpcAction(2-i, i);
				return true;
			}

			for (int i = 0; i < 3; i+=2)
			{
				for(int j = 0; j < 3; j += 2)
				{
					if (arr[i, j] == spacePos)
					{
						NpcAction(i, j);
						return true;
					}
				}
			}
			return false;
		}


		// 設定電腦參數為2
		private void NpcAction(int row, int col)
		{
			arr[row, col] = 2;
			buttonList[row * 3 + col].Image = npc_img;
			buttonList[row * 3 + col].Enabled = false;
		}

		private bool CheckWin(bool player)
		{
			bool playerWinFlag = false, npcWinFlag = false;
			if(player)
				playerWinFlag = ChkLine(true);
			else npcWinFlag = ChkLine(false);
			
			if (playerWinFlag || npcWinFlag)
			{
				MessageBox.Show(playerWinFlag ? "玩家勝利" : "電腦勝利");
				foreach (var item in buttonList)
				{
					item.Enabled = false;
				}
			}
			return false;
		}

		private bool ChkLine(bool player)
		{
			int chkNum = player ? 3 : 6;
			for (int i = 0; i < 3; i++)
			{
				if (arr[i, 0] + arr[i, 1] + arr[i, 2] == chkNum)
				{
					for(int j = 0; j < 3; j++)
					{
						if(arr[i, j] != (player ? 1: 2))
						{
							return false;
						}
					}
					return true;
				}
				if (arr[0, i] + arr[1, i] + arr[2, i] == chkNum)
				{
					for(int j=0; j < 3; j++)
					{
						if (arr[j, i] != (player ? 1: 2))
						{
							return false;
						}
					}
					return true;
				}
			}
			if (arr[0, 0] + arr[1, 1] + arr[2, 2] == chkNum)
			{
				for (int i = 0; i < 3; i++)
					if (arr[i, i] != (player ? 1:2))
						return false;
				return true;
			}
			if (arr[2, 0] + arr[1, 1] + arr[0, 2] == chkNum)
			{
				for(int i = 0; i< 3; i++)
					if (arr[2 - i, i] != (player ? 1 : 2))
						return false;
				return true;
			}
			return false;
		}

		private void CheckPathExists()
		{
			// check the path excist or not
			if (!System.IO.File.Exists(codePath + "Img/img_X.jpg"))
			{
				MessageBox.Show("img_X.jpg not exist");
			}
			if (!System.IO.File.Exists(codePath + "Img/img_O.jpg"))
			{
				MessageBox.Show("img_O.jpg not exist");
			}
		}
	}
}
