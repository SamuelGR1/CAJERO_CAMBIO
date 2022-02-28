static void CAMBIO()
{
	int op, cant,centa, D200, D100, D50, D20, D10, D5,D1,M50,M25,M10,M5,M1;
	cant = D200 = D100 = D50 = D20 = D10 = D5 = D1 = M50 = M25 = M10  = M5 = M1 = 0;
	string dinero;

	double pacentavo, cambio;
	


	Console.WriteLine("BIENVENIDO A MAQUINA DE CAMBIO\n");
	Console.WriteLine("ESCOGE LA OPCION DE DESGLOSE QUE DECEAS REALIZAR\n");
	Console.WriteLine("1.- DESGLOSE NORMAL \n2.- DESGLOSE CON CAMBIO DE $$ A Q");
	Console.WriteLine("OPCION: ");
	op = int.Parse(Console.ReadLine());

	switch (op)
	{

		case 1:

			Console.WriteLine("INGRESE LA CANTIDAD");
			dinero = (Console.ReadLine());

			pacentavo = Convert.ToDouble(dinero);

			cant = Convert.ToInt32(Math.Truncate(pacentavo));
			pacentavo = (pacentavo - cant) * 100; 
			centa = Convert.ToInt32(pacentavo);

			if (cant >= 200)
			{
				D200 = (cant / 200);
				cant = cant - (D200 * 200);

			}

			if (cant >= 100)
			{
				D100 = (cant / 100);
				cant = cant - (D100 * 100);

			}

			if (cant >= 50)
			{
				D50 = (cant / 50);
				cant = cant - (D50 * 50);

			}

			if (cant >= 20)
			{
				D20 = (cant / 20);
				cant = cant - (D20 * 20);

			}
			if (cant >= 10)
			{
				D10 = (cant / 10);
				cant = cant - (D10 * 10);

			}
			if (cant >= 5)
			{
				D5 = (cant / 5);
				cant = cant - (D5 * 5);
			}

			if (cant >= 1)
			{
				D1 = (cant / 1);
				cant = cant - (D1 * 1);

			}


			if (centa >= 50)
			{
				M50 = (centa / 50);
				centa = centa - (M50 * 50);

			}

			if (centa >= 25)
			{
				M25 = (centa / 25);
				centa = centa - (M25 * 25);
			}

			if (centa >= 10)
			{
				M10 = (centa / 10);
				centa = centa - (M10 * 10);
			}

			if (centa >= 5)
			{
				M5 = (centa / 5);
				centa = centa - (M5 * 5);
			}

			if (centa >= 1)
			{
				M1 = (centa / 1);
				centa = centa - (M1 * 1);
			}



			Console.WriteLine($"Billetes de 200: {D200}");
			Console.WriteLine($"Billetes de 100: {D100}");
			Console.WriteLine($"Billetes de  50: {D50}");
			Console.WriteLine($"Billetes de  20: {D20}");
			Console.WriteLine($"Billetes de  10: {D10}");
			Console.WriteLine($"Billetes de   5: {D5}");
			Console.WriteLine($"Billetes de   1: {D1}");
			Console.WriteLine($"\nMONEDA de 0.50: {M50}");
			Console.WriteLine($"MONEDA de 0.25: {M25}");
			Console.WriteLine($"MONEDA de 0.10: {M10}");
			Console.WriteLine($"MONEDA de 0.05: {M5}");
			Console.WriteLine($"MONEDA de 0.01: {M1}");

			break;

		case 2:

			//CODIGO 2 CON CAMBIO DE $$

			Console.WriteLine("INGRESE LA CANTIDAD $$:");
			dinero = (Console.ReadLine());


			pacentavo = Convert.ToDouble(dinero);

			cambio = 7.66;
			pacentavo = (pacentavo * cambio);

			Console.WriteLine($"\n$$ {dinero} en Q =: {pacentavo}\n");

			cant = Convert.ToInt32(Math.Truncate(pacentavo)); 
			pacentavo = (pacentavo - cant) * 100; 
			centa = Convert.ToInt32(pacentavo);
			


			if (cant >= 200)
			{
				D200 = (cant / 200);
				cant = cant - (D200 * 200);

			}

			if (cant >= 100)
			{
				D100 = (cant / 100);
				cant = cant - (D100 * 100);

			}

			if (cant >= 50)
			{
				D50 = (cant / 50);
				cant = cant - (D50 * 50);

			}

			if (cant >= 20)
			{
				D20 = (cant / 20);
				cant = cant - (D20 * 20);

			}
			if (cant >= 10)
			{
				D10 = (cant / 10);
				cant = cant - (D10 * 10);

			}
			if (cant >= 5)
			{
				D5 = (cant / 5);
				cant = cant - (D5 * 5);
			}

			if (cant >= 1)
			{
				D1 = (cant / 1);
				cant = cant - (D1 * 1);

			}


			if (centa >= 50)
			{
				M50 = (centa / 50);
				centa = centa - (M50 * 50);

			}

			if (centa >= 25)
			{
				M25 = (centa / 25);
				centa = centa - (M25 * 25);
			}

			if (centa >= 10)
			{
				M10 = (centa / 10);
				centa = centa - (M10 * 10);
			}

			if (centa >= 5)
			{
				M5 = (centa / 5);
				centa = centa - (M5 * 5);
			}

			if (centa >= 1)
			{
				M1 = (centa / 1);
				centa = centa - (M1 * 1);
			}



			Console.WriteLine($"Billetes de 200: {D200}");
			Console.WriteLine($"Billetes de 100: {D100}");
			Console.WriteLine($"Billetes de  50: {D50}");
			Console.WriteLine($"Billetes de  20: {D20}");
			Console.WriteLine($"Billetes de  10: {D10}");
			Console.WriteLine($"Billetes de   5: {D5}");
			Console.WriteLine($"Billetes de   1: {D1}");
			Console.WriteLine($"\nMONEDA de 0.50: {M50}");
			Console.WriteLine($"MONEDA de 0.25: {M25}");
			Console.WriteLine($"MONEDA de 0.10: {M10}");
			Console.WriteLine($"MONEDA de 0.05: {M5}");
			Console.WriteLine($"MONEDA de 0.01: {M1}");
			break;

	}


}

CAMBIO();