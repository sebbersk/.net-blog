import React from 'react';
import Navbar from './components/Navbar/Navbar';
import PostPreview from './components/PostPreview/PostPreview';
import { Container } from './styles';
import Home from './views/Home';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import SinglePost from './views/SinglePost';
function App() {
	return (
		<BrowserRouter>
			<Navbar />
			<Container>
				<Routes>
					<Route path="/" element={<Home />} />
					<Route path="/posts/:id" element={<SinglePost />} />
				</Routes>
			</Container>
		</BrowserRouter>
	);
}

export default App;
