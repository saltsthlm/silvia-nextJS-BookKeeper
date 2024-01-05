import Link from 'next/link';

export default function FirstPost() {
	const handleRequest = () => {
		const apiFetch = async () => {
			const data = await fetch('http://localhost:5065/WeatherForecast', {
				method: 'GET',
				headers: { 'Content-Type': 'application/json' },
				// body: JSON.stringify({ newWords: newWords }),
			});
			const jsonData = await data.json();
			console.log(jsonData);
		};
		apiFetch();
	};

	return (
		<>
			<h1>First Post</h1>
			<h2>
				<Link href="/">Back to home</Link>
			</h2>
			<button onClick={handleRequest}>Click me!</button>
		</>
	);
}
