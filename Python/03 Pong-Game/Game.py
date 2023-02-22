"""Ping Pong

    game of ping pong demo with turtle interaction

    Doc:
        * window (basic window 800x600)
        * 2 pedals interaction with keyboard (rect)
        * ball (circle)
        * scoreinformation (textlabel)

    Class:
        - window
        - pedal
        - ball

    author: Alfred Becker & Maurice Hofmann
    date: 07.06.2022
    version: 1.0.0
    licence: free

"""
from ast import While
from tkinter import font
import turtle, random, time

class GameWindow:
    __window_width = 800
    __window_height = 600
    __background = "black"
    __title = "Pong Game"

    def __init__(self):
        self.window = turtle.Screen()
        self.window.title(self.__title)
        self.window.bgcolor(self.__background)
        self.window.setup(width=self.__window_width, height=self.__window_height)
        self.window.tracer(0)

        # TODO: scoring
        self.pen = turtle.Turtle()
        self.pen.speed(0)
        self.pen.color("White")
        self.pen.penup()
        self.pen.hideturtle()
        self.pen.goto(0,260)

    def get_window_size(self):
        """get window size parameter

        Returns:
            tupel of window parameter: width x height
        """
        return self.__window_width, self.__window_height


    def show_point(self, a = 0, b = 0):
        """show points of all player

        Args:
            a (int, optional): points of player a. Defaults to 0.
            b (int, optional): points of player b. Defaults to 0.
        """
        self.pen.clear()
        self.pen.write(f"Player A: {a} Player B: {b}", align='Center', font=('Courier', 24, "normal"))


class Paddle:
    __paddle_shape = "square"
    __paddle_color = "white"
    __stretch_wid = 5
    __stretch_len = 1
    __player_points = 0

    def __init__(self, start_x):
        self.my_paddle = turtle.Turtle()
        self.my_paddle.speed(0)
        self.my_paddle.shape(self.__paddle_shape)
        self.my_paddle.color(self.__paddle_color)
        self.my_paddle.shapesize(stretch_wid=self.__stretch_wid, stretch_len=self.__stretch_len)
        self.my_paddle.penup()
        self.my_paddle.start_position = start_x
        self.my_paddle.goto(start_x, 0)
    
    def change_position(self, speed = 20, direction = 1):
        y = self.my_paddle.ycor()
        y += direction * speed
        self.my_paddle.sety(y)

    def get_points(self):
        return self.__player_points

    def set_points(self):
        self.__player_points += 1


        


class Ball:
    __start_position = (0,0)
    __ball_shape = "circle"
    __ball_color = "white"
    __ball_speed = 1 # further function


    def __init__(self):
        self.ball = turtle.Turtle()
        self.ball.shape(self.__ball_shape)
        self.ball.color(self.__ball_color)
        self.ball.penup()
        self.ball.goto(self.__start_position)
        self.ball.__dx = self.ball.__dy = self.__ball_speed


    def __create_startposition(self):
        return (0, random.randint(-200, 200))


    def move_ball(self):
        self.ball.setx(self.ball.xcor() + self.ball.__dx)
        self.ball.sety(self.ball.ycor() + self.ball.__dy)
        


    def check_position(self, player_a, player_b, window):
        # hit out
        if self.ball.xcor() > window.get_window_size()[0]/2 -10:
            self.ball.goto(self.__create_startposition())
            self.ball.__dx *= -1 # Change direction
            # TODO: Player-Point
            player_a.set_points()

        elif self.ball.xcor() < -(window.get_window_size()[0]/2 -10):
            self.ball.goto(self.__create_startposition())
            self.ball.__dx *= -1 # Change direction
            # TODO: Player-Point
            player_b.set_points()


        # hit top and button
        if self.ball.ycor() > window.get_window_size()[1]/2 -10:
            self.ball.sety(window.get_window_size()[1]/2 -10)
            self.ball.__dy *= -1

        elif self.ball.ycor() < -(window.get_window_size()[1]/2 -10):
            self.ball.sety(-(window.get_window_size()[1]/2 -10))
            self.ball.__dy *= -1

        # hit player
        self.__check_collision([player_a, player_b])

    def __check_collision(self, playerlist):
        for player in playerlist:
            if player.my_paddle.start_position > 0:
               # right player
               if self.ball.xcor() + 10 > 340 and (self.ball.ycor() < player.my_paddle.ycor() + 50 and self.ball.ycor() > player.my_paddle.ycor() -50):
                   self.ball.__dx *= -1
            else:
                #left player
                if self.ball.xcor() - 10 < -340 and (self.ball.ycor() < player.my_paddle.ycor() + 50 and self.ball.ycor() > player.my_paddle.ycor() -50):
                   self.ball.__dx *= -1
                
            


def start_game():
    """gamecontroller
        * initialize variables
        * initialize window
        * gameloop

    """
    # variable init
    game_window = GameWindow()


    # window init
    player_a = Paddle(-350) #left of window
    player_b = Paddle(350)  #right of window
    
    ball = Ball()

    game_window.window.listen()
    game_window.window.onkeypress(lambda:player_a.change_position(), "w")
    game_window.window.onkeypress(lambda:player_a.change_position(direction=-1), "s")
    game_window.window.onkeypress(lambda:player_b.change_position(), "Up")
    game_window.window.onkeypress(lambda:player_b.change_position(direction=-1), "Down")



    # gameloop while true
    print ("DEBUG:: start game")
    while True:
        game_window.window.update()

        #time.sleep(1/250)

        game_window.show_point(a=player_a.get_points(), b=player_b.get_points())
        ball.move_ball()
        ball.check_position(player_a=player_a, player_b=player_b, window=game_window)


if __name__ == "__main__":
    start_game()