CREATE TABLE #PicoYPlaca 
( Id int primary key,
Digit int,
"DayOfWeek" varchar(20),
"Hour" int,
"MinutesStart" int,
"MinutesEnd" int
)
-- drop table #PicoYPlaca

select Id 'PicoYPlacaRule.Id', Digit 'PicoYPlacaRule.Digit', "DayOfWeek" 'PicoYPlacaRule.DayOfWeek'
,"Hour" 'PicoYPlacaRule.Hour', "MinutesStart" 'PicoYPlacaRule.MinutesStart', "MinutesEnd" 'PicoYPlacaRule.MinutesEnd'
from #PicoYPlaca
for json path, root('PicoYPlacaRules')

insert into #PicoYPlaca SELECT 1 Id, 1 Digit, 'Monday' "DayOfWeek", 7 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 2 Id, 1 Digit, 'Monday' "DayOfWeek", 8 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 3 Id, 1 Digit, 'Monday' "DayOfWeek", 9 "Hour", 0 "MinutesStart", 30 "MinutesEnd"
insert into #PicoYPlaca SELECT 4 Id, 1 Digit, 'Monday' "DayOfWeek", 16 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 5 Id, 1 Digit, 'Monday' "DayOfWeek", 17 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 6 Id, 1 Digit, 'Monday' "DayOfWeek", 18 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 7 Id, 1 Digit, 'Monday' "DayOfWeek", 19 "Hour", 0 "MinutesStart", 30 "MinutesEnd"
--
insert into #PicoYPlaca SELECT 8 Id, 2 Digit, 'Monday' "DayOfWeek", 7 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 9 Id, 2 Digit, 'Monday' "DayOfWeek", 8 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 10 Id, 2 Digit, 'Monday' "DayOfWeek", 9 "Hour", 0 "MinutesStart", 30 "MinutesEnd"
insert into #PicoYPlaca SELECT 11 Id, 2 Digit, 'Monday' "DayOfWeek", 16 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 12 Id, 2 Digit, 'Monday' "DayOfWeek", 17 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 13 Id, 2 Digit, 'Monday' "DayOfWeek", 18 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 14 Id, 2 Digit, 'Monday' "DayOfWeek", 19 "Hour", 0 "MinutesStart", 30 "MinutesEnd"
--
insert into #PicoYPlaca SELECT 15 Id, 3 Digit, 'Tuesday' "DayOfWeek", 7 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 16 Id, 3 Digit, 'Tuesday' "DayOfWeek", 8 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 17 Id, 3 Digit, 'Tuesday' "DayOfWeek", 9 "Hour", 0 "MinutesStart", 30 "MinutesEnd"
insert into #PicoYPlaca SELECT 18 Id, 3 Digit, 'Tuesday' "DayOfWeek", 16 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 19 Id, 3 Digit, 'Tuesday' "DayOfWeek", 17 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 20 Id, 3 Digit, 'Tuesday' "DayOfWeek", 18 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 21 Id, 3 Digit, 'Tuesday' "DayOfWeek", 19 "Hour", 0 "MinutesStart", 30 "MinutesEnd"
--
insert into #PicoYPlaca SELECT 22 Id, 4 Digit, 'Tuesday' "DayOfWeek", 7 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 23 Id, 4 Digit, 'Tuesday' "DayOfWeek", 8 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 24 Id, 4 Digit, 'Tuesday' "DayOfWeek", 9 "Hour", 0 "MinutesStart", 30 "MinutesEnd"
insert into #PicoYPlaca SELECT 25 Id, 4 Digit, 'Tuesday' "DayOfWeek", 16 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 26 Id, 4 Digit, 'Tuesday' "DayOfWeek", 17 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 27 Id, 4 Digit, 'Tuesday' "DayOfWeek", 18 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 28 Id, 4 Digit, 'Tuesday' "DayOfWeek", 19 "Hour", 0 "MinutesStart", 30 "MinutesEnd"
--
insert into #PicoYPlaca SELECT 29 Id, 5 Digit, 'Wednesday' "DayOfWeek", 7 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 30 Id, 5 Digit, 'Wednesday' "DayOfWeek", 8 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 31 Id, 5 Digit, 'Wednesday' "DayOfWeek", 9 "Hour", 0 "MinutesStart", 30 "MinutesEnd"
insert into #PicoYPlaca SELECT 32 Id, 5 Digit, 'Wednesday' "DayOfWeek", 16 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 33 Id, 5 Digit, 'Wednesday' "DayOfWeek", 17 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 34 Id, 5 Digit, 'Wednesday' "DayOfWeek", 18 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 35 Id, 5 Digit, 'Wednesday' "DayOfWeek", 19 "Hour", 0 "MinutesStart", 30 "MinutesEnd"
--
insert into #PicoYPlaca SELECT 36 Id, 6 Digit, 'Wednesday' "DayOfWeek", 7 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 37 Id, 6 Digit, 'Wednesday' "DayOfWeek", 8 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 38 Id, 6 Digit, 'Wednesday' "DayOfWeek", 9 "Hour", 0 "MinutesStart", 30 "MinutesEnd"
insert into #PicoYPlaca SELECT 39 Id, 6 Digit, 'Wednesday' "DayOfWeek", 16 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 40 Id, 6 Digit, 'Wednesday' "DayOfWeek", 17 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 41 Id, 6 Digit, 'Wednesday' "DayOfWeek", 18 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 42 Id, 6 Digit, 'Wednesday' "DayOfWeek", 19 "Hour", 0 "MinutesStart", 30 "MinutesEnd"
--
insert into #PicoYPlaca SELECT 43 Id, 7 Digit, 'Thursday' "DayOfWeek", 7 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 44 Id, 7 Digit, 'Thursday' "DayOfWeek", 8 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 45 Id, 7 Digit, 'Thursday' "DayOfWeek", 9 "Hour", 0 "MinutesStart", 30 "MinutesEnd"
insert into #PicoYPlaca SELECT 46 Id, 7 Digit, 'Thursday' "DayOfWeek", 16 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 47 Id, 7 Digit, 'Thursday' "DayOfWeek", 17 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 48 Id, 7 Digit, 'Thursday' "DayOfWeek", 18 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 49 Id, 7 Digit, 'Thursday' "DayOfWeek", 19 "Hour", 0 "MinutesStart", 30 "MinutesEnd"
--
insert into #PicoYPlaca SELECT 50 Id, 8 Digit, 'Thursday' "DayOfWeek", 7 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 51 Id, 8 Digit, 'Thursday' "DayOfWeek", 8 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 52 Id, 8 Digit, 'Thursday' "DayOfWeek", 9 "Hour", 0 "MinutesStart", 30 "MinutesEnd"
insert into #PicoYPlaca SELECT 53 Id, 8 Digit, 'Thursday' "DayOfWeek", 16 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 54 Id, 8 Digit, 'Thursday' "DayOfWeek", 17 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 55 Id, 8 Digit, 'Thursday' "DayOfWeek", 18 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 56 Id, 8 Digit, 'Thursday' "DayOfWeek", 19 "Hour", 0 "MinutesStart", 30 "MinutesEnd"
--
insert into #PicoYPlaca SELECT 57 Id, 9 Digit, 'Friday' "DayOfWeek", 7 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 58 Id, 9 Digit, 'Friday' "DayOfWeek", 8 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 59 Id, 9 Digit, 'Friday' "DayOfWeek", 9 "Hour", 0 "MinutesStart", 30 "MinutesEnd"
insert into #PicoYPlaca SELECT 60 Id, 9 Digit, 'Friday' "DayOfWeek", 16 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 61 Id, 9 Digit, 'Friday' "DayOfWeek", 17 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 62 Id, 9 Digit, 'Friday' "DayOfWeek", 18 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 63 Id, 9 Digit, 'Friday' "DayOfWeek", 19 "Hour", 0 "MinutesStart", 30 "MinutesEnd"
--
insert into #PicoYPlaca SELECT 64 Id, 0 Digit, 'Friday' "DayOfWeek", 7 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 65 Id, 0 Digit, 'Friday' "DayOfWeek", 8 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 66 Id, 0 Digit, 'Friday' "DayOfWeek", 9 "Hour", 0 "MinutesStart", 30 "MinutesEnd"
insert into #PicoYPlaca SELECT 67 Id, 0 Digit, 'Friday' "DayOfWeek", 16 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 68 Id, 0 Digit, 'Friday' "DayOfWeek", 17 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 69 Id, 0 Digit, 'Friday' "DayOfWeek", 18 "Hour", 0 "MinutesStart", 59 "MinutesEnd"
insert into #PicoYPlaca SELECT 70 Id, 0 Digit, 'Friday' "DayOfWeek", 19 "Hour", 0 "MinutesStart", 30 "MinutesEnd"
