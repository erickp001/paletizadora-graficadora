using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaletizadoraV1._0
{
    internal class ControlPosicion
    {
        static public USBcontrol PinguinoBoard;
        static public bool calibradoPaletizadora = false;
        static public bool calibradoDibujo = false;
        static public bool calibradoGraficadora = false;
        static public int ejeX = 1;
        static public int ejeY = 1;
        static public int posicionActualX = 1;
        static public int posicionActualY = 1;
        static public string ecuacion, subecuacion, rem, nuevo, unico;
        static public double resultado;
        static public int largo, lugar, lugarM, lugarD, lugarS, lugarR, lugarA, lugarC, lugarP, lugarQ, lugarCo, lugarSe, lugarTa;
        static public bool multiplicacion, division, suma, raiz, potencia, resta, abierto, decision, root, sen, cos, tan;
        static public int n = 0;
        static public int a,grafica;
        static public int conA;
        static public int conB;
        static public string prueba = "";
        static public bool omitir;
        static public int signos = 0;
        static public bool agrupado, negativo, negativo1, negatividad, negado, error, error1, MyD, multi, div, conservarR, ConservarS;
        static public bool licenciaS, par, soloA, soloB, syntaxerror;
        static public int punto = 46;//46 punto 44 coma
        static public char puntoC = '.';
        static public string puntito = ".";
        static public bool PinzaClose = false;
        static public bool vastagoOut = false;
    }
}
