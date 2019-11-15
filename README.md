# MVMEvolutiveAlgorithm
MVM test

En este ejercicio vamos a implementar un algoritmo evolutivo, los pasos se describen a continuación:

•	Iniciar con una cadena aleatoria de 26 caracteres. 
•	Realizar 50 copias de la cadena inicial, teniendo en cuenta que cada carácter en la cadena copiada tendrá un 3% de probabilidad de que sea reemplazado por un nuevo carácter aleatorio.
•	Comparar cada una de las 50 cadenas generadas con el texto “MVM INGENIERIA DE SOFTWARE”, y dar a cada cadena un puntaje. El puntaje corresponde al número de caracteres en la cadena copiada que se corresponden con el texto “MVM INGENIERIA DE SOFTWARE”. Por ejemplo, el puntaje para la cadena “MVA INGENIKRIA DE SOHTWARO” es 22 (hay 4 caracteres incorrectos entre los 26).
•	Si alguna de las cadenas generadas tiene un puntaje perfecto (26 puntos), el algoritmo termina.
•	De otro modo, se debe tomar la cadena (entre las 50 generadas) que tenga el puntaje más alto y volver al paso 2, tomando dicha cadena como punto de partida.
•	Cada iteración de este algoritmo se conoce como una Generación. Se requiere mostrar en pantalla la cadena con el puntaje más alto de cada generación.
•	Para propósitos de este algoritmo, un carácter es cualquier letra en mayúscula, o un espacio en blanco.
•	Los caracteres correctos de cada generación no se bloquean, esto quiere decir que un carácter correcto se podría volver incorrecto en las generaciones subsecuentes

Ejemplo:
 Generación: 1 - Mutación: LQCXM GFZOFEBVXCZKXWQFQDAV - Puntaje: 1
 Generación: 2 - Mutación: LQCXM GFZOFEBV CZKXWQFQDAV - Puntaje: 2
 Generación: 3 - Mutación: LQCXM GFZOFEBA CZKXWQFQDAV - Puntaje: 3
 Generación: 4 - Mutación: LQCXM GFZOFEBA CZKXWQFQDAN - Puntaje: 3
 …
 Generación: 10 - Mutación: MQMXM GFZOFCBA CE SWQFQDQE - Puntaje: 9
 Generación: 11 - Mutación: MQMXM GFZOFCBA CE SWQTQDQE - Puntaje: 10
 Generación: 12 - Mutación: MQMXM GFZOFCBA CE SWQTQDQE - Puntaje: 10
 …
 Generación: 148 - Mutación: MVM IWGENIERIA DE SOFTWARE - Puntaje: 25
 Generación: 149 - Mutación: MVM IWGENIERIA DE SOFTWARE - Puntaje: 25
 Generación: 150 - Mutación: MVM INGENIERIA DE SOFTWARE - Puntaje: 26
