import sys
import pandas as pd

# Variablen
dateiname = "Ums2020Berlin.csv"

# Einlesen der CSV-Datei in DataFrame
umsatz_2020_dataframe = pd.read_csv(dateiname, sep='#')

# Ermitteln des maximalen, minimalen und duchschnittlichen Umsatzwertes
max_umsatz = umsatz_2020_dataframe["Umsatz"].max()
min_umsatz = umsatz_2020_dataframe["Umsatz"].min()
avg_umsatz = umsatz_2020_dataframe["Umsatz"].mean()

# Ausgabe der ermittelten Temperaturwerte
print(f"Der höchste Umsatz beträgt {max_umsatz} EUR")
print(f"Der geringste Umsatz beträgt {min_umsatz} EUR")
print(f"Der durchschnittliche Umsatz beträgt {round(avg_umsatz, 2)} EUR")