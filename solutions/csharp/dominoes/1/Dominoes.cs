public static class Dominoes
{
    public static bool CanChain(IEnumerable<(int, int)> dominoes)
    {
        var stones = dominoes.ToList();

        if(stones.Count == 0) return true;

        var firstStone = stones[0];
        var rest = stones.Skip(1).ToList();

        var normal = new List<(int,int)> {firstStone};
        var flipped = new List<(int,int)> { (firstStone.Item2, firstStone.Item1)};

        return TryChain(new List<(int,int)>(rest), normal) || TryChain(new List<(int,int)>(rest), flipped);
    }

    private static bool TryChain(List<(int,int)> remaining, List<(int,int)> chain)
    {
        if(remaining.Count == 0)
        {
            return chain[0].Item1 == chain[chain.Count - 1].Item2;
        }

        int currRightEnd = chain[chain.Count - 1].Item2;

        for(int i = 0; i < remaining.Count; i++)
        {
            var stone = remaining[i];
            var orientations = new[] {stone, (stone.Item2, stone.Item1)};

            foreach(var oriented in orientations)
            {
                if(oriented.Item1 == currRightEnd)
                {
                    remaining.RemoveAt(i);
                    chain.Add(oriented);

                    if(TryChain(remaining, chain))
                    {
                        return true;
                    }

                    chain.RemoveAt(chain.Count - 1);
                    remaining.Insert(i, stone);
                }
            }
        }
        return false;
    }
}