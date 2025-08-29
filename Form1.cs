using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_1___Array_Operations
{
	public partial class Form1 : Form
	{
		int[] Grades;
		Random Rand = new Random();

		public Form1()
		{
			InitializeComponent();
			int GradeCount = 0;
			if(ValidateClassSize(ref GradeCount))
			{
				Grades = new int[GradeCount];
			} else
			{
				Grades = new int[30];
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private bool ValidateClassSize(ref int Out)
		{
			Out = (int)numClassSize.Value;

			if (Out <= 0)
			{
				MessageBox.Show("Please enter a class size greater than 0.");
				return false;
			}
			return true;
		}

		private bool ValidateMaxGrade(ref int Out)
		{
			Out = (int)numMaxGrade.Value;
			if (Out <= 0)
			{
				MessageBox.Show("Please enter a max grade value greater than 0.");
				return false;
			}
			return true;
		}

		private void Reset(object sender, EventArgs e)
		{
			int ClassSize = 0;
			if (!ValidateClassSize(ref ClassSize))
				return;
			Grades = new int[ClassSize];
			lstGrades.Items.Clear();
			numMaxGrade.Value = 100;
			numClassSize.Value = 30;
			lblCommonGradeOut.Text = String.Empty;
			lblNumTimesOut.Text = String.Empty;
		}

		//Returns how many times a specific grade appears in the grade list.
		private int CountOccurrences(int grade, int[] gradeList)
		{
			int Count = 0;
			foreach (int item in gradeList)
			{
				if (grade == item) Count++;
			}
			return Count;
		}

		//Finds the index of the highest value in the counts array and returns it
		private int FindMaxPos(int[] counts)
		{
			int MaxValue = 0;
			int MaxPos = 0;
			for (int i = 0; i < counts.Length; i++)
			{
				int item = counts[i];
				if (item > MaxValue)
				{
					MaxValue = item; 
					MaxPos = i;
				}
			}
			return MaxPos;
		}

		//Determines which grade occurs most often using the CountOccurrences method.
		private int FindMostCommonGrade(int maxGrade, int[] gradeList)
		{
			bool[] LookUp = new bool[maxGrade];
			int BestGradeCount = 0;
			int BestGrade = 0;
			foreach (int item in gradeList)
			{
				if (LookUp[item] == true)
					continue;
				LookUp[item] = true;
				int Occurance = CountOccurrences(item, gradeList);
				if(Occurance > BestGradeCount)
				{
					BestGradeCount = Occurance;
					BestGrade = item;
				}
			}
			return BestGrade;
		}

		private void DisplayData()
		{
			int MostCommonGrade = FindMostCommonGrade(Grades[FindMaxPos(Grades)] + 1, Grades);
			int Occurances = CountOccurrences(MostCommonGrade, Grades);
			lblCommonGradeOut.Text = MostCommonGrade.ToString();
			lblNumTimesOut.Text = Occurances.ToString();
		}

		private void bntPopulateGrades_Click(object sender, EventArgs e)
		{
			int ClassSize = 0;
			int MaxGrade = 0;
			if (!ValidateClassSize(ref ClassSize))
				return;

			if (!ValidateMaxGrade(ref MaxGrade))
				return;

			Grades = new int[ClassSize];
			string Out = "";

			for (int i = 0; i < ClassSize; i++) {
				Grades[i] = Rand.Next(MaxGrade);
				lstGrades.Items.Add(Grades[i]);
				Out = Out + Grades[i].ToString();
				if(i != ClassSize - 1)
					Out = Out + ",";
			}
			lblCopy.Text = Out;
			DisplayData();
		}
	}
}
