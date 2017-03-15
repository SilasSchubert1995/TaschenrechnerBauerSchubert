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
        variable1 = Ergebnislabel.Text();
        ergebnis = variable1 + variable2;
    }

    public void Subtrahieren()
    {
        variable1 = Ergebnislabel.Text();
        ergebnis = variable1 - variable2;
    }

    public void Multiplizieren()
    {
        variable1 = Ergebnislabel.Text();
        ergebnis = variable1 * variable2;
    }

    public void Dividieren()
    {
        variable1 = Ergebnislabel.Text();
        ergebnis = variable1 / variable2;
    }

    public int Ergebnisübergabe()
    {
        variable2 = Ergebnislabel.Text();
        return ergebnis;
    }
}
