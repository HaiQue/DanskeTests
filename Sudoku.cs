private static bool ValidateSolution(int[,] board) { 

    if (board.Length != 9)
        return false;

    int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9};
    int[] rows = new int[9];
    int[] columns = new int[9];

    //go through board line by line
    for (int i = 0; i < board.Length; i++)
        for (int j = 0; j < board.Length; j++) {
            rows[j] = board[i, j];
            columns[j] = board[j, i];
        }
    
    if (!ArraysAreEqual(numbers, rows))
         return false;

    if (!ArraysAreEqual(numbers, columns))
        return false;

    List<int> horizontal = new List<int>();
    List<int> vertical = new List<int>();
    List<int> diagonal = new List<int>();
    for (int i = 0; i < 3; i++) {
        
        //Horizontal squares
        for (int x = 0; x < 3; x++) {
            for (int y = 0; y < 3; y++) {
                horizontal.Add(board[x + i, y]);
            }
        }

        //Vertial squares
        for (int x = 0; x < 3; x++) {
            for (int y = 0; y < 3; y++) {
                vertical.Add(board[x, y + i]);
            }
        }

        //Diagon squares
        for (int x = 0; x < 3; x++) {
            for (int y = 0; y < 3; y++) {
                diagonal.Add(board[x + i, y + i]);
            }
        }
    }

    if (!ArraysAreEqual(numbers, horizontal.ToArray()))
        return false;

    if (!ArraysAreEqual(numbers, vertical.ToArray()))
        return false;
    
    if (!ArraysAreEqual(numbers, diagonal.ToArray()))
        return false;


    return true;
  }

  private static bool ArraysAreEqual(int[] arr1, int[] arr2) {

    foreach (int value1 in arr1)
        foreach (int value2 in arr2) 
            if (value1 != value2 && value2 != 0)
                return false;
    return true;
  }
