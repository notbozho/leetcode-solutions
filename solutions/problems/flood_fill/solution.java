class Solution {
    public int[][] floodFill(int[][] image, int sr, int sc, int color) {
        if(image[sr][sc] == color) return image;

        int[][] directions = {
                {0, 0},
                {1, 0},
                {-1, 0},
                {0, 1},
                {0, -1},
        };

        Queue<int[]> checkQueue = new LinkedList<>();
        boolean[][] checked = new boolean[image.length][image[0].length];

        for (int i = 0; i < image.length; i++) {
            for (int j = 0; j < image[0].length; j++) {
                checked[i][j] = false;
            }
        }

        int startValue = image[sr][sc];

        checkQueue.add(new int[] {sr, sc});

        while (!checkQueue.isEmpty()) {
            int[] currentCoords = checkQueue.poll();

            for (int[] direction : directions) {
                int nx = 0;
                int ny = 0;

                int dnx = currentCoords[0] + direction[0];
                int dny = currentCoords[1] + direction[1];

                if ((dnx >= 0 && dnx <= image.length - 1) && (dny >= 0 && dny <= image[dnx].length - 1)) {
                    nx = dnx;
                    ny = dny;
                } else {
                    continue;
                }

//                if (dnx >= 0 && dnx <= image.length - 1) nx = dnx;
//                if (dny >= 0 && dny <= image[nx].length - 1) ny = dny;
//
//                if (currentCoords[0] != 0 && currentCoords[0] != image.length - 1) nx = currentCoords[0] + direction[0];
//                if (currentCoords[1] != 0 && currentCoords[1] != image[nx].length - 1) ny = currentCoords[1] + direction[1];

                if (image[nx][ny] == startValue && !checked[nx][ny]) {
                    image[nx][ny] = color;
                    checked[nx][ny] = true;
                    checkQueue.add(new int[] {nx, ny});
                } else {
                    checked[nx][ny] = true;
                }
            }
        }

        return image;
    }
}