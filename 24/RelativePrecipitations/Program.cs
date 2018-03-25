using System;

namespace RelativePrecipitations {
	class Program {
		static void Main(string[] args) {
			int[] precipitations = { 23, 45, 4545, 2, -16, 765, 341, 1, -3, 0, 12, 110 };

			// изменяем массив
			for (int i = 0; i < precipitations.Length; i++) {
				precipitations[i] = precipitations[i] - precipitations[0];
			}

			// выводим результат
			for (int i = 0; i < precipitations.Length; i++) {
				Console.WriteLine(precipitations[i]);
			}
			Console.ReadLine();
		}
	}
}
