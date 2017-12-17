using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WorkTimeCalculator
{
	public partial class WorkTimeCalculatorForm : Form
	{
		public string inputInData;
		public string inputOutData;

		public WorkTimeCalculatorForm()
		{
			InitializeComponent();
		}

		private void OutTimeTableInputText_TextChanged(object sender, EventArgs e)
		{
			TextBox inputField = (TextBox)sender;

			inputOutData = inputField.Text;
		}

		private void InTimeTableInputText_TextChanged(object sender, EventArgs e)
		{
			TextBox inputField = (TextBox)sender;

			inputInData = inputField.Text;
		}

		private void ParseButton_Click(object sender, EventArgs e)
		{
			if (inputInData == string.Empty || inputOutData == string.Empty)
			{
				return;
			}

            OutputText.Text = ParseInputData();
		}

		private string ParseInputData ()
		{
			string output = string.Empty;

			string usableInData = PrepareDataForUse(inputInData);
			string usableOutData = PrepareDataForUse(inputOutData);

			string[] inTimes = usableInData.Split(';');
			string[] outTimes = usableOutData.Split(';');

			List<string[]> parsedInData = PrepareDataCollection(inTimes, true);
			List<string[]> parsedOutData = PrepareDataCollection(outTimes, false);

			int totalTime = 0;

			for (int i = 0; i < parsedOutData.Count; i++)
			{
				string[] inData = parsedInData[i];
				string[] outData = parsedOutData[i];

				TimeSpan inTime = new TimeSpan();
				TimeSpan outTime = new TimeSpan();

				TimeSpan.TryParse(inData[1], out inTime);
				TimeSpan.TryParse(outData[1], out outTime);

				TimeSpan timeDifference = outTime - inTime;

				totalTime += (int)timeDifference.TotalMinutes;

				output += string.Format("Date: {0}\t{1} - {2}\t Total: {3}min of 480min ({4}min)\r\n",
					inData[0],
					inData[1],
					outData[1],
					Math.Round(timeDifference.TotalMinutes),
					(Math.Round(timeDifference.TotalMinutes - 480)).ToString());
			}

            int requiredTime = parsedOutData.Count * 8 * 60;
			int totalTimeDifference = totalTime - requiredTime;

			output += string.Format(
				"You should have around {0} min until now and you have {1} min\r\n",
				requiredTime.ToString(),
				totalTime.ToString());


			if (totalTimeDifference > 0)
			{
				output += "You have " + totalTimeDifference.ToString() + "min to spend."; 
			}
			else
			{
				output += "You're " + Math.Abs(totalTimeDifference).ToString() + "min behind."; 
			}

			return output;
		}

		private string PrepareDataForUse (string input)
		{
			string output = input;

			// remove spaces
			output = output.Replace(" ", "");

			// convert tabs to ats
			output = output.Replace('\t', '@');

			// convert new lines to semicolons
			output = output.Replace("\n", ";");

			return output;
		}

		private List<string[]> PrepareDataCollection (string[] input, bool truncateDatesForward)
		{
			List<string[]> output = ConvertStringsToArrays(input);

			output = RemoveDuplicates(output, truncateDatesForward);
			output = RemoveUnusedData(output);

			return output;
		}

		private List<string[]> ConvertStringsToArrays (string[] input)
		{
			List<string[]> output = new List<string[]>();

			for (int i = 0; i < input.Length; i++)
			{
				string[] splitData = input[i].Split('@');

				DateTime inputDate = new DateTime();

				// check if the current line is correct
				if (input[i] == string.Empty || DateTime.TryParse(splitData[0], out inputDate) == false)
				{
					continue;
				}

				output.Add(splitData);
			}

			return output;
		}

		private List<string[]> RemoveDuplicates (List<string[]> input, bool truncateForward)
		{
			List<string[]> output = new List<string[]>();

			// invert the table to remove all dates before the correct one
			if (truncateForward == true)
			{
				input.Reverse();
			}

			// remove duplicates
			for (int i = 0; i < input.Count - 1; i++)
			{
				if (input[i][0] != input[i + 1][0])
				{
					output.Add(input[i]);
				}
			}

			// after truncating revert the table to original order
			if (truncateForward == true)
			{
				output.Reverse();
			}

			return output;
		}

		private List<string[]> RemoveUnusedData (List<string[]> input)
		{
			List<string[]> output = input;

			for (int i = 0; i < output.Count; i++)
			{
				string[] toChange = output[i];
				string[] changed = new string[]{toChange[0], toChange[3]};

				output[i] = changed;
			}

			return output;
		}
	}
}
