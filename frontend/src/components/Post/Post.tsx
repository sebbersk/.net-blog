import React from 'react';
import { StyledPost } from './Post.styles';

type Props = {
	id: string;
	title: string;
	content: string;
	authorId: string;
	createdAt: string;
};

const Post = ({ title, content, createdAt }: Props) => {
	return (
		<StyledPost>
			<h1>{title}</h1>
			<p>{content}</p>
			<span>{new Date(createdAt).toLocaleString()}</span>
		</StyledPost>
	);
};

export default Post;
