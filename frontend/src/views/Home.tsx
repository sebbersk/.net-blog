import React from 'react';
import PostPreview from '../components/PostPreview/PostPreview';
import useFetch from '../hooks/useFetch';

interface Post {
	id: string;
	title: string;
	content: string;
	authorId: string;
	createdAt: string;
}

const Home = () => {
	const { data, loading, error } = useFetch<Post[]>('/api/posts');
	return (
		<>
			{loading && <div>Loading posts...</div>}
			{error && <div>Error: {error.message}</div>}
			{data &&
				data.map((post: Post, idx: number) => {
					return <PostPreview key={post.id} {...post} />;
				})}
		</>
	);
};

export default Home;
