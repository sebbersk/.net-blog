import styled from 'styled-components';

export const PostCard = styled.div`
	-webkit-box-shadow: 1px 5px 20px 5px rgba(0, 0, 0, 0.5);
	box-shadow: 1px 5px 20px 5px rgba(0, 0, 0, 0.5);
	padding: 10px 20px;
	border-radius: 10px;
	margin: 25px 0;
	& h2 {
		border-bottom: 1px solid #aaa;
		display: inline;
	}
	& p {
		color: #aaa;
	}
	&:hover {
		cursor: pointer;
		opacity: 0.6;
	}
`;
