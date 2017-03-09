using System;

public class Rechnen
{
	public Rechnen()
	{
        int variable1 = 0;
        int variable2 = 0;
        int ergebnis = 0;
	}

    public void Addieren()
    {
        ergebnis = variable1 + variable2;
    }

    public void Subtrahieren()
    {
        ergebnis = variable1 - variable2;
    }

    public void Multiplizieren()
    {
        ergebnis = variable1 * variable2;
    }

    public void Dividieren()
    {
        ergebnis = variable1 / variable2;
    }

    public int Ergebnisübergabe()
    {
        return ergebnis;
    }
}
