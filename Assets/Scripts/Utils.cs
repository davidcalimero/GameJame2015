//------------------------------------------------------------------------------
// <auto-generated>
//     Este código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.18444
//
//     As alterações a este ficheiro poderão provocar um comportamento incorrecto e perder-se-ão se
//     o código for regenerado.
// </auto-generated>
//------------------------------------------------------------------------------
using System;

public static class Utils {

	public static float minMaxNormalization(float currentNumber, float oldMin, float oldMax, float newMin, float newMax){
		return ((currentNumber - oldMin) / (oldMax - oldMin)) * (newMax - newMin) + newMin; 
	}
}


