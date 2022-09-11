import { useState, useEffect } from 'react';
import axios from 'axios';

const useFetch = <T>(url: string) => {
	const [data, setData] = useState<T | null>(null);
	const [loading, setLoading] = useState<boolean>(false);
	const [error, setError] = useState<Error | null>(null);
	console.log(url);

	useEffect(() => {
		setLoading(true);
		axios
			.get(url)
			.then((res) => setData(res.data))
			.catch((error) => setError(error))
			.finally(() => setLoading(false));
	}, [url]);

	return { data, loading, error };
};
export default useFetch;
