USE Geography
SELECT  CountryName,
		CountryCode,
	Case
		WHEN CurrencyCode = 'EUR' THEN 'Euro'
		WHEN CurrencyCode != 'EUR' THEN 'Not Euro'
		ELSE 'Not Euro'
	END AS Currency
	FROM Countries
	ORDER BY CountryName