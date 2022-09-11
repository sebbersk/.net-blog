import styled from 'styled-components';

export const StyledPost = styled.div`
	padding: 20px;
	margin: 20px 0;
	-webkit-box-shadow: 1px 5px 20px 5px rgba(0, 0, 0, 0.5);
	box-shadow: 1px 5px 20px 5px rgba(0, 0, 0, 0.5);
	border-radius: 5px;
	display: flex;
	flex-direction: column;
	& h1 {
		margin-bottom: 10px;
	}
	& p {
		padding: 0 10px;
		margin-bottom: 10px;
	}
	& span {
		align-self: flex-end;
		color: #999;
	}
`;
