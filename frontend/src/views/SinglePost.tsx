import React from 'react';
import { useParams } from 'react-router-dom';
import Post from '../components/Post/Post';
import useFetch from '../hooks/useFetch';

interface Post {
	id: string;
	title: string;
	content: string;
	authorId: string;
	createdAt: string;
}
const SinglePost = () => {
	const { id } = useParams();
	const { data, loading, error } = useFetch<Post>(`/api/posts/${id}`);
	console.log(data, loading, error);

	return (
		<>
			{loading && <div>Loading</div>}
			{error && <div>Error: {error.message}</div>}
			{data && <Post {...data} />}
		</>
	);
};

export default SinglePost;
