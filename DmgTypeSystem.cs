using System;

public class DamageTypeSystem
{
	/*Assign Types to Magic Skills (Dark, Holy, Fire, Ice, Wind, Earth, Water), and Assign Types to Non-Magic Skills and Basic Attacks
	 (Slash and Blunt, maybe add another? Consult team)*/
	public enum Types
	{
		None,
		Dark,
		Holy,
		Fire,
		Ice,
		Wind,
		Earth,
		Water,
		Slash,
		Blunt
	}
	public class DamageTypeSystem()
	{
		static float[][] chart =
		{
							 /* Dark Holy Fire Ice Wind Earth Water Slash Blunt (In this order for each float)
			/*Dark*/ new float[] { 0.5f, 2f, 1f, 1f, 1f, 1f, 1f, 1f, 1f},
            /*Holy*/ new float[] { 2f, 0.5f, 1f, 1f, 1f, 1f, 1f, 1f, 1f},
            /*Fire*/ new float[] { 2f, 0.5f, 1f, 2f, 1f, 1f, 0.5f, 1f, 1f},
            /*Ice*/ new float[] { 1f, 1f, 0.5f, 1f, 2f, 1f, 2f, 1f, 1f},
            /*Wind*/ new float[] { 1f, 1f, 2f, 0.5f, 1f, 2f, 1f, 1f, 1f},
            /*Earth*/ new float[] { 1f, 1f, 1f, 1f, 0.5f, 1f, 2f, 1f, 2f},
            /*Water*/ new float[] { 1f, 1f, 2f, 0.5f, 1f, 0.5f, 1f, 1f, 1f},
            /*Slash*/ new float[] { 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 0.5f},
            /*Blunt*/ new float[] { 1f, 1f, 1f, 2f, 1f, 0.5f, 0.5f, 2f, 1f},
		};

		public static float Effectiveness(Types attacker, Types defender)
		{
			if (attacker == Types.None || defender == Types.None)
				return 1;

			int row = (int)attacker - 1;
			int col = (int)defender - 1;

			return chart[row][col];
		}
	}
}
