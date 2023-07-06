import tkinter

# Taschenrechner GUI mit pysimplegui
# https://www.geeksforgeeks.org/calculator-using-pysimplegui-python/

class Main_Window:
    # Fenstereigenschaft
    main_window = tkinter.Tk()
    main_window.title("Taschenrechner")
    main_window.geometry("280x380")
    main_window.configure(background="#5A5A5A")

    rechnung = tkinter.StringVar()

    #================================
    # Methoden
    #================================
    # Startet das Programm
    def start(self):
        #================================
        # Fenster
        #================================
        # Anlegen eines Fensters und setzen von Eigenschaften
        # Steuerelemente
        # Anzeige
        self.lbl_anzeige = tkinter.Label(self.main_window,  text=self.rechnung.get(), height=2, width=16, background="#5A5A5A", foreground="white", font=("Arial", 22), anchor="e")
        self.lbl_anzeige.grid(row=1, columnspan=5)
        

        # Zahlenfeld & Mathematische Operatoren
        btn_1 = tkinter.Button(self.main_window, text="1", width=8, height=4, bg="#424549", fg="white", command=lambda: self.hinzufügenRechnung("1")) 
        btn_1.grid(row=2, column=1)

        btn_2 = tkinter.Button(self.main_window, text="2", width=8, height=4, bg="#424549", fg="white", command=lambda: self.hinzufügenRechnung("2"))
        btn_2.grid(row=2, column=2)

        btn_3 = tkinter.Button(self.main_window, text="3", width=8, height=4, bg="#424549", fg="white", command=lambda: self.hinzufügenRechnung("3"))
        btn_3.grid(row=2, column=3)

        btn_4 = tkinter.Button(self.main_window, text="4", width=8, height=4, bg="#424549", fg="white", command=lambda: self.hinzufügenRechnung("4"))
        btn_4.grid(row=3, column=1)

        btn_5 = tkinter.Button(self.main_window, text="5", width=8, height=4, bg="#424549", fg="white", command=lambda: self.hinzufügenRechnung("5"))
        btn_5.grid(row=3, column=2)

        btn_6 = tkinter.Button(self.main_window, text="6", width=8, height=4, bg="#424549", fg="white", command=lambda: self.hinzufügenRechnung("6"))
        btn_6.grid(row=3, column=3)

        btn_7 = tkinter.Button(self.main_window, text="7", width=8, height=4, bg="#424549", fg="white", command=lambda: self.hinzufügenRechnung("7"))
        btn_7.grid(row=4, column=1)

        btn_8 = tkinter.Button(self.main_window, text="8", width=8, height=4, bg="#424549", fg="white", command=lambda: self.hinzufügenRechnung("8"))
        btn_8.grid(row=4, column=2)

        btn_9 = tkinter.Button(self.main_window, text="9", width=8, height=4, bg="#424549", fg="white", command=lambda: self.hinzufügenRechnung("9"))
        btn_9.grid(row=4, column=3)

        btn_0 = tkinter.Button(self.main_window, text="0", width=8, height=4, bg="#424549", fg="white", command=lambda: self.hinzufügenRechnung("0"))
        btn_0.grid(row=5, column=2)

        btn_komma = tkinter.Button(self.main_window, text=",", width=8, height=4, bg="#424549", fg="white", command=lambda: self.hinzufügenRechnung("."))
        btn_komma.grid(row=5, column=1)

        btn_plus = tkinter.Button(self.main_window, text="+", width=8, height=4, bg="#1EBDD7", fg="white", command=lambda: self.hinzufügenRechnung(" + "))
        btn_plus.grid(row=2, column=4)

        btn_minus = tkinter.Button(self.main_window, text="-", width=8, height=4, bg="#1EBDD7", fg="white", command=lambda: self.hinzufügenRechnung(" - "))
        btn_minus.grid(row=3, column=4)

        btn_mal = tkinter.Button(self.main_window, text="X", width=8, height=4, bg="#1EBDD7", fg="white", command=lambda: self.hinzufügenRechnung(" * "))
        btn_mal.grid(row=4, column=4)

        btn_geteilt = tkinter.Button(self.main_window, text="÷", width=8, height=4, bg="#1EBDD7", fg="white", command=lambda: self.hinzufügenRechnung(" / "))
        btn_geteilt.grid(row=5, column=4)

        btn_berechne = tkinter.Button(self.main_window, text="=", width=8, height=4, bg="#4169E1", fg="white", command=lambda: self.evaluieren())
        btn_berechne.grid(row=5, column=3)

        self.main_window.mainloop()



    def hinzufügenRechnung(self, value):
        self.rechnung.set(self.rechnung.get() + value)
        self.lbl_anzeige.configure(text=self.rechnung.get())

    def evaluieren(self):
        result = eval(self.rechnung.get())
        self.lbl_anzeige.configure(text=result)  

        self.rechnung.set(result)


# Starten des Programms
my_window_obj = Main_Window()
my_window_obj.start()
