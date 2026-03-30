### APDB_CW_1

### Struktura
- Struktura jest podzielona na Modele reprezentujące faktyczne modele danych podane w wymaganiach, oraz na serwisy, zawierające logikę.
- Metody klasowe odpowiadają za dodawanie listowanie i działanie na całym zbiorze danej klasy. Modyfikowanie zmiana, zmiana wybranych pól odbywa się poprzez metody obiektowe.
- W pliku Program.cs znajduję się demo z przykładowymi danymi

Podział został wybrany w oparciu na odróżnienie reprezentacji faktycznych modeli biznesowych z wymaganymi polami od klas zawierających definicje danych operacji. Ułatwia to ewentualne zmiany w kodzie i pozwala na ponowne użycie w wielu metodach klasowych. 
