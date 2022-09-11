import React from 'react';
import { useNavigate } from 'react-router-dom';
import { PostCard } from './PostPreview.styles';

type Props = {
	id: string;
	title: string;
	content: string;
	AuthorId?: string;
	CreatedAt?: string;
};

const PostPreview = ({ title, content, id }: Props) => {
	const navigate = useNavigate();
	const truncateText = (text: string): string => {
		if (text.length > 120) {
			return text.slice(0, 120) + '...';
		} else {
			return text;
		}
	};

	const handleClick = (event: React.MouseEvent<HTMLDivElement>) => {
		navigate(`/posts/${id}`);
	};
	return (
		<PostCard onClick={handleClick}>
			<h2>{title}</h2>
			<p>{truncateText(content)}</p>
		</PostCard>
	);
};

export default PostPreview;
