using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace Monopoly
{
    /// <summary>
    /// The export class will make it easier to export tables of data. For example: to a excel sheet.
    /// </summary>
    public static class Export
    {
        public static void ToExcel_TileStepSimulation(List<float[]> data, int startRound, int roundMultiplier)
        {
            var excelApp = new Excel.Application();

            // Make the object visible.
            excelApp.Visible = true;

            // Create a new, empty workbook and add it to the collection returned
            // by property Workbooks. The new workbook becomes the active workbook.
            // Add has an optional parameter for specifying a particular template.
            // Because no argument is sent in this example, Add creates a new workbook.
            excelApp.Workbooks.Add();

            // This example uses a single workSheet. The explicit type casting is
            // removed in a later procedure.
            Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;

            #region Normal Data:
            workSheet.Cells[1, "A"] = "TileId";
            workSheet.Cells[1, "A"].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
            workSheet.Cells[1, "A"].Font.Bold = true;

            for (int i = 0; i < data[0].Length; i++)
            {
                workSheet.Cells[2 + i, "A"] = $"{i + 1}";
            }

            for (int i = 0; i < data.Count; i++)
            {
                workSheet.Cells[1, $"{(char)((int)'B' + i)}"] = $"{startRound * Math.Pow(roundMultiplier, i)}";
                workSheet.Cells[1, $"{(char)((int)'B' + i)}"].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                workSheet.Cells[1, $"{(char)((int)'B' + i)}"].Font.Bold = true;
            }

            for (int i = 0; i < data.Count; i++)
            {
                for (int y = 0; y < data[i].Length; y++)
                {
                    workSheet.Cells[y + 2  , $"{(char)((int)'B' + i)}"] = data[i][y];
                }
            }
            #endregion

            List<float> averages = new List<float>();
            for (int i = 0; i < data.Count - 1; i++)
            {
                List<float> diffs = new List<float>();
                if (i + 1 < data.Count)
                {
                    float[] first = data[i];
                    float[] second = data[i + 1];

                    for (int y = 0; y < first.Length; y++)
                    {
                        float diff = first[y] - second[y];
                        if(diff < 0) { diff = diff * (-1); }
                        diffs.Add(diff);
                    }
                }
                averages.Add(diffs.Sum() / diffs.Count);
            }

            workSheet.Cells[1, "I"] = "Round Differences:";
            workSheet.Cells[1, "I"].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
            workSheet.Cells[1, "I"].Font.Bold = true;
            workSheet.Columns[$"I"].columnWidth = 20;

            for (int z = 0; z < averages.Count; z++)
            {
                workSheet.Columns[$"{(char)((int)'J' + z)}"].columnWidth = 15;

                workSheet.Cells[1, $"{(char)((int)'J' + z)}"] = $"{startRound * Math.Pow(roundMultiplier, z)} - {startRound * Math.Pow(roundMultiplier, z+1)}";
                workSheet.Cells[1, $"{(char)((int)'J' + z)}"].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                workSheet.Cells[1, $"{(char)((int)'J' + z)}"].Font.Bold = true;

                workSheet.Cells[2, $"{(char)((int)'J' + z)}"] = $"{averages[z]}";
            }
        }

        public static void ToExcel_MonopolySimulation()
        {

        }
    }
}
