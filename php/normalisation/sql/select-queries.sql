-- Various Select Queries to do with the Denormalised and Normalised tables.
-- (c) 2010-03-05, Robert Impey

-- For the denormalised table

SELECT
	*
FROM
	denormalised_swimming_sessions
ORDER BY
	session_date;
	
-- For the normalised table

SELECT
	swimming_sessions.id,
	swimming_sessions.session_date,
	swimming_sessions.number_of_lengths,
	swimmers.first_name,
	swimmers.last_name,
	swimming_pools.name AS swimming_pool,
	swimming_pools.swimming_pool_length
FROM
	swimmers,
	swimming_pools,
	swimming_sessions
WHERE
	swimming_sessions.swimmer_id = swimmers.id
	AND
	swimming_sessions.swimming_pool_id = swimming_pools.id
ORDER BY
	swimming_sessions.session_date;

SELECT
	swimming_sessions.id,
	swimming_sessions.session_date,
	swimming_sessions.number_of_lengths,
	swimmers.first_name,
	swimmers.last_name,
	swimming_pools.name AS swimming_pool,
	swimming_pools.swimming_pool_length
FROM
	swimming_sessions
LEFT JOIN
	(swimmers, swimming_pools)
ON 
	(
		swimming_sessions.swimmer_id = swimmers.id
		AND
		swimming_sessions.swimming_pool_id = swimming_pools.id
	)
ORDER BY
	swimming_sessions.session_date;
