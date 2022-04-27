SELECT
    d.[zrodlo],
    r.[id],r.[def],FK.defRej.rNazwa,d.[skrot],d.[numer],r.[dId],r.[rokDok],r.[numerWl],r.[datadok],r.[dataWS],
	r.[kontrahent],
	'nip' = ISNULL( dkh.[VatId], '' ),
	r.[typabc],r.[okres],r.[nienaliczany],
	[netto],[vat],r.[brutto], r.[stawka],
	d.[sygnatura],d.[tresc], d.[nazwa], d.[dataOkr], r.[Oczek], d.[dataOper],
	r.[znacznik],
	'kh_nazwa' = ISNULL( dkh.[Name], '' ),
	r.[ue], r.[usluga], r.[sOczek]
	,r.[bruttoWaluta], r.[nettoWaluta], r.[vatWaluta]
FROM FK.[rejVat] AS r  JOIN FK.[dokumenty] AS d
ON  r.[dId]=d.[id] AND d.[rokId] = r.[rokDok]
JOIN FK.FROK ON FK.FROK.rokId = d.rokId
JOIN FK.defRej ON FK.defRej.id = r.def
LEFT JOIN ( SELECT 
				cast(Elements1.[AccountNo] as int) AS FkId, 
				Con.Id, Con.Name, 
				Con.NIP As VatId 
			FROM SSCommon.[STContractors] as Con   
				INNER JOIN SSCommon.[STElements] as Elements1 ON(Elements1.[Guid] = Con.[MainElement])) 
			dkh ON dkh.FkId = r.kontrahent
WHERE ( (r.[def] = -2 AND 2=0) OR defRej.rZs = :regType) AND (1 <> 0 or r.[netto] <> 0) -- defRej.rZs = 1 zakup / defRej.rZs = 2 sprzedaż
	AND Format(d.dataOper,'yyyy-MM-dd') between ':year-01-01' and ':year-12-31'  --( ( r.okres >= FROK.poczatek AND r.okres <= FROK.koniec) OR (d.[rokId] = 19))
	and r.kontrahent in (:firms)--(2148,1914,9142,17275,1385,10711,10396,9166,17274,9373,10022,12801,12800,12961,16012,15435,15314,1365,17167,1013,17097,17320,42993,42992,47305,47235,14422,14423,14832,15117,38038,56627,9153,89427) 
order by
d.datadok	