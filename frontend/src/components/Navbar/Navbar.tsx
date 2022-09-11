import React from 'react';
import { StyledNavbar } from './Navbar.styles';
import { Link } from 'react-router-dom';
const Navbar = () => {
	return (
		<StyledNavbar>
			<Link to="/">
				<h1>Blog App</h1>
			</Link>
		</StyledNavbar>
	);
};

export default Navbar;
