﻿#region Level 1 Task 1

Console.WriteLine("Level 1 Task 1: \n");
string ins = "inside";
string outs = "outside";
double x_1_1, y_1_1, r_1_1;
r_1_1 = 2;
Console.Write("Enter x: ");
x_1_1 = double.Parse(Console.ReadLine());
Console.Write("Enter y: ");
y_1_1 = double.Parse(Console.ReadLine());
if (Math.Abs(x_1_1 * x_1_1 + y_1_1 * y_1_1 - r_1_1 * r_1_1) <= Math.Pow(10, -3)) Console.WriteLine(ins);
else Console.WriteLine(outs);

#endregion


#region Level 1 Task 2

Console.WriteLine("Level 1 Task 2: \n");
double x_1_2, y_1_2;
bool l_1_2 = false;
Console.Write("Enter x: ");
x_1_2 = double.Parse(Console.ReadLine());
Console.Write("Enter y: ");
y_1_2 = double.Parse(Console.ReadLine());
if (y_1_2 >= 0 && Math.Abs(x_1_2) + y_1_2 <= 1) l_1_2 = !l_1_2;
Console.WriteLine(l_1_2);

#endregion


#region Level 2 Task 1

Console.WriteLine("Level 2 Task 1: \n");
double sr, r_2_1, s_2_1 = 0;
double n_1_2 = 0;
do
{
	Console.WriteLine("Enter height. To end the program, enter 0");
	r_2_1 = double.Parse(Console.ReadLine());
	if (r_2_1 == 0) break;
	s_2_1 += r_2_1;
	n_1_2++;
} while (r_2_1 > 0);
sr = s_2_1 / n_1_2;
Console.WriteLine("Average height is: {0}", sr);

#endregion


#region Level 2 Task 2

Console.WriteLine("Level 2 Task 2: \n");
double x_2_2, y_2_2, r_2_2;
int n_2_2 = 0;
Console.WriteLine("Enter radius");
r_2_2 = double.Parse(Console.ReadLine());
do
{
	Console.WriteLine("Enter X. To end the program, enter 1000");
	x_2_2 = double.Parse(Console.ReadLine());
	if (x_2_2 >= 1000) break;
	Console.WriteLine("Enter Y");
	y_2_2 = double.Parse(Console.ReadLine());
	if (x_2_2 * x_2_2 + y_2_2 * y_2_2 <= r_2_2 * r_2_2) n_2_2++;
} while (x_2_2 < 1000);
Console.WriteLine("got into the circle: {0}", n_2_2);

#endregion


#region Level 3 Task 4

Console.WriteLine("Level 3 Task 4: \n");
double x_3_4, y_3_4, r_3_4_1, r_3_4_2;
int n_3_4 = 0;
Console.WriteLine("Enter r1");
r_3_4_1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter r2");
r_3_4_2 = double.Parse(Console.ReadLine());
do
{
	Console.WriteLine("Enter X. To end the program, enter 1000");
	x_3_4 = double.Parse(Console.ReadLine());
	if (x_3_4 >= 1000) break;
	Console.WriteLine("Enter Y");
	y_3_4 = double.Parse(Console.ReadLine());
	if ((x_3_4 * x_3_4 + y_3_4 * y_3_4 <= r_3_4_1 * r_3_4_1) && (x_3_4 * x_3_4 + y_3_4 * y_3_4 <= r_3_4_2 * r_3_4_2)) n_3_4++;
} while (x_3_4 < 1000);
Console.WriteLine("got into: {0}", n_3_4);

#endregion


#region Level 3 Task 11

Console.WriteLine("Level 3 Task 11: \n");
double srb_3_11 = 0, a_3_11 = 0, b_3_11 = 0;
int z_3_11, ot_3_11, ft_3_11 = 0, sb_3_11, cal_3_11;
do
{
	sb_3_11 = 0;
	cal_3_11 = 0;
	Console.Write($"enter points for exam 1 or type smth not in [2:5]");
	int.TryParse(Console.ReadLine(), out ot_3_11);
	if (ot_3_11 < 2 || ot_3_11 > 5)
	{
		break;
	}
	if (ot_3_11 == 2)
	{
		cal_3_11++;
	}
	sb_3_11 = sb_3_11 + ot_3_11;
	for (z_3_11 = 2; z_3_11 < 5; z_3_11++)
	{
		Console.Write($"enter points for exam {z_3_11}");
		int.TryParse(Console.ReadLine(), out ot_3_11);
		while (ot_3_11 < 2 || ot_3_11 > 5)
		{
			Console.WriteLine("points can be only 2-5");
			Console.WriteLine($"enter points for exam {z_3_11}");
			int.TryParse(Console.ReadLine(), out ot_3_11);
		}
		if (ot_3_11 == 2)
		{
			cal_3_11++;
		}
		sb_3_11 = sb_3_11 + ot_3_11;
	}
	if (cal_3_11 > 0)
	{
		ft_3_11++;
	}
	a_3_11 = a_3_11 + sb_3_11;
	b_3_11++;
} while (ot_3_11 >= 2 && ot_3_11 <= 5);
if (b_3_11 > 0)
{
	srb_3_11 = a_3_11 / b_3_11 / 4;
}
Console.WriteLine($"number of loosers - {ft_3_11}, average points - {srb_3_11}");

#endregion


#region Level 3 Task 12

Console.WriteLine("Level 3 Task 12: \n");
Console.WriteLine("Enter number how many mach repet program:");
int n_3_12 = Convert.ToInt32(Console.ReadLine());
for (int i_3_12 = 0; i_3_12 < n_3_12; i_3_12++)
{
	Console.Write("Enter r:");
	double r_3_12 = Convert.ToDouble(Console.ReadLine());
	Console.Write("Choose the number from 1 to 3 (1-square area, 2-circle area area, 3-equilateral triangle)");
	double c_3_12 = Convert.ToDouble(Console.ReadLine());
	switch (c_3_12)
	{
		case 1:
			Console.WriteLine($" The rectangle area = {r_3_12 * r_3_12}");
			break;
		case 2:
			Console.WriteLine($" The rectangle area = {Math.PI * Math.Pow(r_3_12, 2)}");
			break;
		case 3:
			Console.WriteLine($" The rectangle area = {Math.Pow(r_3_12, 2) * Math.Sqrt(3) / 4}");
			break;
	}
}

#endregion


#region Level 3 Task 13

Console.WriteLine("Level 3 Task 13: \n");
Console.WriteLine("Enter quanity A and B");
int n_3_13 = Convert.ToInt32(Console.ReadLine());
double l_3_13;
for (int i_3_13 = 0; i_3_13 < n_3_13; i_3_13++)
{
	Console.Write("Enter A: ");
	double a_3_13 = Convert.ToDouble(Console.ReadLine());
	Console.Write("Enter B: ");
	double b_3_13 = Convert.ToDouble(Console.ReadLine());
	Console.WriteLine("Choose the number from 1 to 3 (1 - the rectangle area, 2 - the ring area, 3 - the area of isisceles triangle)");
	double d_3_13 = Convert.ToDouble(Console.ReadLine());
	switch (d_3_13)
	{
		case 1:
			Console.WriteLine($" The rectangle area = {a_3_13 * b_3_13}");
			break;
		case 2:
			if (a_3_13 > b_3_13)
			{
				Console.WriteLine($" The ring area = {Math.PI * a_3_13 * a_3_13 - Math.PI * b_3_13 * b_3_13}");
			}
			else Console.WriteLine($" The ring area = {Math.PI * b_3_13 * b_3_13 - Math.PI * a_3_13 * a_3_13}");
			break;
		case 3:
			l_3_13 = Math.Sqrt(b_3_13 * b_3_13 - (a_3_13 * a_3_13 / 4));
			Console.WriteLine($" The area of isisceles triangle = {0.5 * a_3_13 * l_3_13}");
			break;
		default:
			break;
	}
}

#endregion