class Solution {
    static int islands;
    static int[][] directions = {
            {0, 0},
            {1, 0},
            {-1, 0},
            {0, 1},
            {0, -1}
    };
    static char[][] g;
    static boolean[][] checked;

    public static void getConnected(int x, int y) {
        if (checked[x][y]) return;

        Queue<int[]> queue = new LinkedList<>();

        queue.add(new int[] {x, y});

        while (!queue.isEmpty()) {
            int[] currCoords = queue.poll();

            for (int[] direction : directions) {
                int nx = 0;
                int ny = 0;

                int dnx = currCoords[0] + direction[0];
                int dny = currCoords[1] + direction[1];

                if ((dnx >= 0 && dnx <= g.length - 1) && (dny >= 0 && dny <= g[dnx].length - 1) && !checked[dnx][dny]) {
                    nx = dnx;
                    ny = dny;
                } else {
                    continue;
                }

                if(g[nx][ny] == '1') {
                    checked[nx][ny] = true;
                    queue.add(new int[]{nx, ny});
                }
            }
        }

        islands++;
    }

    public static int numIslands(char[][] grid) {
        islands = 0;
        g = grid;
        checked = new boolean[grid.length][grid[0].length];

        for (int i = 0; i < grid.length; i++) {
            for (int j = 0; j < grid[0].length; j++) {
                checked[i][j] = false;
            }
        }

        for (int i = 0; i < grid.length; i++) {
            for (int j = 0; j < grid[0].length; j++) {
                if (grid[i][j] == '1' && !checked[i][j]) getConnected(i, j);
            }
        }

        return islands;
    }
}