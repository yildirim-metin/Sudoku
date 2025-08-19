using System.ComponentModel;
using System.Numerics;
using System.Text.RegularExpressions;

namespace SudokuConsole.Common;

internal class Zone
{
    private uint _values;

    public Zone()
    {
        Init();
    }

    public Zone(uint values)
    {
        _values = values;
    }

    public void Init()
    {
        _values = 0;
    }

    public bool Contains(int value)
    {
        uint mask = (uint)1 << value - 1;
        return (_values & mask) == mask;
    }

    public bool Add(int value)
    {
        if (!Contains(value))
        {
            uint mask = (uint)1 << value - 1;
            _values |= mask;
            return true;
        }
        else
        {
            return false;
        }

        // uint old = _values;
        // values |= (uint)(1 << value - 1);
        // return old != values;
    }

    public bool Remove(int value)
    {
        if (!Contains(value))
        {
            return false;
        }
        else
        {
            uint mask = (uint)1 << 0 << value - 1;
            _values &= ~mask;
            return true;
        }

        //uint old = _values;
        //_values &= (uint)~(1 << value - 1);
        //return old != _values;
    }

    public Zone Combine(Zone other)
    {
        uint combinedValues = _values | other._values;
        return new Zone(combinedValues);
    }

    public int Count()
    {
        return BitOperations.PopCount(_values);
    }

    public override string ToString()
    {
        string binary = Convert.ToString(_values, 2).PadLeft(32,'0');
        var octets = Enumerable.Range(0, 4)
            .Select(i => binary.Substring(i * 8, 8))
            .Select(b => $"{b.Substring(0, 4)}.{b.Substring(4, 4)}");

        return string.Join(" ", octets);
    }
}
