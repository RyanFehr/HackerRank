'''
Problem: https://www.hackerrank.com/challenges/matrix-rotation-algo
Python Version: 3

Thoughts:
We imagine that every layer of the Matrix is a snake that we need to unroll and then roll up back to the matrix.
Step 1: Unroll each snake into one-dimensional array.
Step 2: Shift cells in the array.
Step 3: Put rotated snake back into the Matrix.

Time Complexity:  TBD
Space Complexity: TBD
'''


class SnakePit:
    def __init__(self, rows_count, columns_count, matrix):
        assert rows_count > 1
        assert columns_count > 1
        assert min(rows_count, columns_count) % 2 == 0

        self.rows_count = rows_count
        self.columns_count = columns_count
        self.matrix = matrix
        # shorter notation for convenience
        self.m = rows_count
        self.n = columns_count

        # calculate number of snakes in the pit
        min_side_length = min(self.m, self.n)  # always even
        self.number_of_snakes = min_side_length // 2  # integral division

        # declare tuple access constants for usage convenience when reading unrolled snake
        self.SNAKE_NODE_VALUE = 0
        self.SNAKE_NODE_ROW = 1
        self.SNAKE_NODE_COLUMN = 2

    def unroll_snake(self, snake_id):
        assert 0 <= snake_id < self.number_of_snakes

        width = self.get_snake_width(snake_id)
        height = self.get_snake_height(snake_id)

        # unrolled snake will consist of tuples
        # [ (value, row, column), (value, row, column), ... ]
        unrolled_snake = []
        # unroll the top (top is always present)
        for i in range(width):
            row = snake_id
            column = snake_id + i
            unrolled_snake.append((self.matrix[row][column], row, column))
        # unroll the right side
        if height >= 3:
            for i in range(height - 2):
                row = snake_id + 1 + i
                column = snake_id + width - 1
                unrolled_snake.append((self.matrix[row][column], row, column))
        # unroll the bottom (from right to left)
        if height > 1:
            for i in range(width):
                row = snake_id + height - 1
                column = snake_id + width - i - 1
                unrolled_snake.append((self.matrix[row][column], row, column))
        # unroll the left side (from bottom to top)
        if height >= 3 and width > 1:
            for i in range(height - 2):
                row = snake_id + height - 2 - i
                column = snake_id
                unrolled_snake.append((self.matrix[row][column], row, column))

        return unrolled_snake

    def rollup_snake(self, unrolled_snake):
        for i in range(len(unrolled_snake)):
            value = unrolled_snake[i][self.SNAKE_NODE_VALUE]
            row = unrolled_snake[i][self.SNAKE_NODE_ROW]
            column = unrolled_snake[i][self.SNAKE_NODE_COLUMN]
            # set value back to the snake pit (matrix)
            self.matrix[row][column] = value

    def print_snake_pit(self):
        for line in self.matrix:
            print(' '.join(str(element) for element in line))

    def print_snake(self, unrolled_snake):
        print(' '.join([str(x[self.SNAKE_NODE_VALUE]) for x in unrolled_snake]))

    def rotate_all_snakes(self, rotations_count):
        for snake_id in range(self.number_of_snakes):
            self.rotate_snake(snake_id, rotations_count)

    def rotate_snake(self, snake_id, rotations_count):
        # crops full circle rotations
        rotations_count = self.calculate_rotation_count_for_snake(snake_id, rotations_count)

        # quit method if no rotation is required
        if rotations_count == 0:
            return

        # unroll the snake
        unrolled_snake = self.unroll_snake(snake_id)

        # collect values from original snake
        original_snake_values = []
        for i in range(len(unrolled_snake)):
            original_snake_values.append(unrolled_snake[i][self.SNAKE_NODE_VALUE])

        # build the result of rotation/shift/offset of the values in the snake
        rotated_snake_values = []
        for i in range(rotations_count, len(unrolled_snake)):
            rotated_snake_values.append(original_snake_values[i])
        for i in range(rotations_count):
            rotated_snake_values.append(original_snake_values[i])

        # write rotated values back to unrolled snake
        for i in range(len(unrolled_snake)):
            updated_snake_node = (
                rotated_snake_values[i],
                unrolled_snake[i][self.SNAKE_NODE_ROW],
                unrolled_snake[i][self.SNAKE_NODE_COLUMN]
            )
            unrolled_snake[i] = updated_snake_node

        # roll the snake back to the pit
        self.rollup_snake(unrolled_snake)

    def calculate_rotation_count_for_snake(self, snake_id, rotations_count):
        snake_length = self.get_snake_length(snake_id)

        # crop rotations count, because full circle = no rotation
        # after this we guarantee that rotations_count < snake_length
        rotations_count %= snake_length
        return rotations_count

    def get_snake_length(self, snake_id):
        assert 0 <= snake_id < self.number_of_snakes

        width = self.get_snake_width(snake_id)
        height = self.get_snake_height(snake_id)

        # minimal length is 2
        length = width * (2 if height > 1 else 1) + max(height - 2, 0) * (2 if width > 1 else 1)
        assert length >= 2
        return length

    def get_snake_width(self, snake_id):
        assert 0 <= snake_id < self.number_of_snakes

        width = self.n - 2 * snake_id
        assert width > 0
        return width

    def get_snake_height(self, snake_id):
        assert 0 <= snake_id < self.number_of_snakes

        height = self.m - 2 * snake_id
        assert height > 0
        return height

rows, columns, rotations_count = [int(x) for x in input().strip().split(' ')]
input_matrix = []
for i in range(rows):
    input_matrix.append([int(x) for x in input().strip().split(' ')])

snake_pit = SnakePit(rows, columns, input_matrix)
snake_pit.rotate_all_snakes(rotations_count)
snake_pit.print_snake_pit()
