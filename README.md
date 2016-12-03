# Artikel "Mit Events zu einer Zuständigkeit" in der dotnetpro 1/17

In diesem Repo finden Sie alle Beispiele aus dem Artikel. Fragen und Rückmeldungen dazu gerne hier oder per Formular auf www.David-Tielke.de

## Hinweise zur Umsetzung
Als Beispiel einer Lösung mit reinen OO-Mitteln wurde im Artikel das Decorator-Pattern gewählt. An der Stelle ist dem Autor klar,
dass natürlich auch andere Lösungen wie Vererbung oder andere Patterns möglich gewesen wäre. Jedoch hätten alle ähnliche 
Probleme und Nachteile gehabt.

## Hinwei zur Architektur
Die Beispielimplementierung soll den Einsatz von Events und Delegaten zur Entkopplung zeigen. Dabei ist die hier gezeigte
Lösung nicht für die Praxis geeignet, da natürlich nur bis zur Klassenebene entkoppelt wurde. Die im Projekt genutzten
Verzeichnisse wie Data oder Logic sollen nur eine ungefähre Struktur der Makro-Architektur andeuten und stellen keinen
Implementierungsvorschlag für diese dar. Eine geeignete Architektur in der so etwas umgesetzt werden könnte finden Sie
unter https://github.com/DavidTielke/CoCo.CSharp.KontaktManager

## Hinweis zur Lösung mittels Factory
Im diesem Artikel und vielen anderen predigt der Autor die Verwendung des SRP. An der Stelle ist klar, dass durch das abonnieren
des Events in der Factory genau dieses Prinzip verletzt wird und soll nur zur Veranschaulichung genutzt werden. Der tatsächliche Ort,
an dem diese "Verknüpfung" stattfinden sollte, varriert je nach eingesetzer Architektur.
