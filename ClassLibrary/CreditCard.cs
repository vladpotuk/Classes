using System;

public class CreditCard
{
    private double balance;

    public double Balance
    {
        get { return balance; }
        set { balance = value; }
    }


    public CreditCard(double balance)
    {
        this.balance = balance;
    }


    public static CreditCard operator +(CreditCard card, double amount)
    {
        card.balance += amount;
        return card;
    }


    public static CreditCard operator -(CreditCard card, double amount)
    {
        card.balance -= amount;
        return card;
    }


    public static bool operator ==(CreditCard card1, CreditCard card2)
    {
        if (ReferenceEquals(card1, card2))
        {
            return true;
        }

        if (ReferenceEquals(card1, null) || ReferenceEquals(card2, null))
        {
            return false;
        }

        return card1.balance == card2.balance;
    }


    public static bool operator !=(CreditCard card1, CreditCard card2)
    {
        return !(card1 == card2);
    }


    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is CreditCard))
        {
            return false;
        }

        CreditCard card = (CreditCard)obj;
        return this.balance == card.balance;
    }


    public override int GetHashCode()
    {
        return balance.GetHashCode();
    }


    public static bool operator >(CreditCard card1, CreditCard card2)
    {
        return card1.balance > card2.balance;
    }


    public static bool operator <(CreditCard card1, CreditCard card2)
    {
        return card1.balance < card2.balance;
    }
}
