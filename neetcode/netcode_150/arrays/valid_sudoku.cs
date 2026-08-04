
public class Solution {
    public bool IsValidSudoku(char[][] board) {
        Dictionary<int, HashSet<int>> lines = new();
        Dictionary<int, HashSet<int>> columns = new();
        Dictionary<int, HashSet<int>> boxes = new();
        var len = board.Length;
        for(int i = 0 ; i < len; ++i)
        {
            lines[i] = new HashSet<int>();
            columns[i] = new HashSet<int>();
            boxes[i] = new HashSet<int>();
        }
        
        for(int i = 0 ; i < len; ++i)
        {
            for(int j = 0 ; j < len; ++j)
            {
                if(char.IsDigit(board[i][j]))
                {
                    var value = board[i][j] - '0';

                    if(lines[i].Contains(value)) return false;
                    if(columns[j].Contains(value)) return false;

                    var box_index = 3 *(i / 3) + (j / 3);

                    if(boxes[box_index].Contains(value)) return false;

                    lines[i].Add(value);
                    columns[j].Add(value);
                    boxes[box_index].Add(value);
                }
            }
        }
        return true;
    }
}
