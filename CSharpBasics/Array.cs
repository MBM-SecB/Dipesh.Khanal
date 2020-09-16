class Array
{
    void learn1DArrays()
    {
        int[] ages = new int[5];
        ages[0] = 23;
        ages[1] = 23;
        ages[2] = 23;
        ages[3] = 23;

        int[] ages2 = new int[] { 23, 43, 12, 45 };
        int[] age3 = { 23, 56, 67 };
    }

    void learnMDArrays()
    {
        int[,] mulTable = new int[3, 4];
        mulTable[0, 1] = 2;

        double[,,] mulTable2 = new double[3, 4, 2];
        mulTable2[0, 0, 0] = 2.56;


    }
    void learnJaggedArrays()
    {
        int[][] mulTable = new int[3][];
        mulTable[0] = new int[] { 2, 4, 6 };
        mulTable[1] = new int[] { 2, 4 };
        mulTable[1] = new int[] { 2, 4, 6, 67, 278 };

    }
}