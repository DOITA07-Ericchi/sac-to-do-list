using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAC_ToDoList {
	public class Utilities {

		public static string ControllaVuoti (string value) {
			bool valido = true;
			if (value == "") {
				valido = false;
			}
			while (!valido) {
				if (value == "") {
					Console.Write ("Hai inserito un testo vuoto. Riprova: ");
					value = Console.ReadLine ();
				} else {
					valido = true;
				}
			}
			return value;
		}

		public static DateOnly ControllaData (string value) {
			CultureInfo japan = CultureInfo.GetCultureInfo ("ja-JP");
			DateOnly data = new DateOnly ();
			bool valido = DateOnly.TryParse (value, japan, DateTimeStyles.None, out data);
			while (!valido) {
				Console.Write ("Data non valida. Riprova (yyyy/mm/dd): ");
				value = Console.ReadLine ();
				valido = DateOnly.TryParse (value, japan, DateTimeStyles.None, out data);
			}
			return data;
		}

		public static DateTime ControllaDataOra (string value) {
			CultureInfo japan = CultureInfo.GetCultureInfo ("ja-JP");
			DateTime dataOra = new DateTime ();
			bool valido = DateTime.TryParse (value, japan, DateTimeStyles.None, out dataOra);
			while (!valido) {
				Console.Write ("Data non valida. Riprova (yyyy/mm/dd): ");
				value = Console.ReadLine ();
				valido = DateTime.TryParse (value, japan, DateTimeStyles.None, out dataOra);
			}
			return dataOra;
		}

		public static uint ControllaUint (string value) {
			bool valido = true;
			uint numero = 0;
			valido = uint.TryParse (value, out numero);
			while (!valido) {
				Console.Write ("Non hai inserito un numero intelligibile. Riprova: ");
				value = Console.ReadLine ();
				valido = uint.TryParse (value, out numero);
			}
			return numero;
		}

		public static double ControllaDouble (string value) {
			bool valido = true;
			double numero = 0;
			valido = double.TryParse (value, out numero);
			while (!valido) {
				Console.Write ("Non hai inserito un numero intelligibile. Riprova: ");
				value = Console.ReadLine ();
				valido = double.TryParse (value, out numero);
			}
			return numero;
		}

		public static bool Convalida () {
			bool si = true;
			bool valid = false;
			do {
				string letter = Console.ReadLine ().ToLower ();
				if (letter == "s" || letter == "n" || letter == "") {
					valid = true;
					if (letter == "s") {
						si = true;
					} else {
						si = false;
					}
				} else {
					Console.Write ("Non è una scelta valida. Inserisci \"s\" o \"n\": ");
				}
			} while (!valid);
			return si;
		}

	}
}