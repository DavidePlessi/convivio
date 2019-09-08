# Convivio

## Purpose
Semplificare la gestione della convivenza tra coinquilini:
- divisione delle spese
- turni di pulizia

## Technologies
Il software sarà un applicazione web con parte backend .NET MCV Core 3, parte frontend Angular 8 e MySql come database.

## Main features

### Gestione coinquilini 
Il software dovrà essere in grado di gestire da 1 a n coinquilini, registrando almeno un recapito per la comunicazine. Dovrà essere possibile tener traccia dei debiti e/o crediti da un coinquilino verso un altro coinquilino.

### Gestione spese
Il software dovrà permette l'inserimento di spese fatte da uno o più coinquilini e ripartire la giusta quota a debito o a credito. Questo implica una sorta di relazione coinquilino a coinquilino che tenga traccia del debito o credito di uno nei confronti dell' altro.

### Turni di pulizia
Il software dovrà essere in grado, una volta impostato un piano di schedulazione, suddividere le zone da pulire tra i coinquilini notificando loro cosa c'è da fare. Deve essere possibile modificare il turno riassegnando le zone da pulire e deve esserci la possibilità, dopo questa modifica di propagare ai turni futuri oppure di mantenere la vecchia programmazione.

### Storicità e analisi
Ogni spesa o movimentazione deve essere registrata e deve essere possibile avere una sorta di quadro delle spese dato un periodo x - y.

### Utenze
Le utente potrebbero essere trattate come una sorta di spesa ma in ogni momento si deve sapere a chi è intestato cosa.