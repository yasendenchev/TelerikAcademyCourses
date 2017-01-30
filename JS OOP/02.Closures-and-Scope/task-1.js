/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	Each book has unique title, author and ISBN???
				*	It must return the newly created book with assigned ID
				*	If the category is missing, it must be automatically created
			*	List all books
				*	Books are sorted by ID
				*	???book can be done by author, by category or all
			*	List all categories
				*	Categories are sorted by ID
		*	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
			*	When adding a book/category, the ID is generated automatically
		*	Add validation everywhere, where possible
			*	Book title and category title must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			*	Author is any non-empty string
			*	Unique params are Book title and Book ISBN
			*	Book ISBN is an unique code that contains either 10 or 13 digits
			*	If something is not valid - throw Error
*/
'use strict';
function solve() {

	var library = (function () {
		var books = [];
		var categories = [];

		function listBooks(filter) {
			let arr = [];
			if (filter != undefined) {
				for (let i = 0; i < books.length; i++) {
					if (books[i].category === filter.category) {
						arr.push(books[i]);
					}
				}
			}
			else {
				for (let i = 0; i < books.length; i++) {
					arr.push(books[i]);
				}
			}
			return arr;
		}

		function addBook(book) {
			if (book.title.length <= 2 || book.title.length >= 100 || book.category.length <= 2 || book.category.length >= 100) {
				throw Error;
			}
			if (book.author === null) {
				throw Error;
			}
			if (book.isbn.length !== 10 && book.isbn.length !== 13) {
				throw Error;
			}
			if (!categories.includes(book.category)) {
				categories.push(book.category);
			}
			if (books.some(e => e.title === book.title)) {
				throw Error;
			}
			if (books.some(b => b.isbn === book.isbn)) {
				throw Error;
			}
			book.ID = books.length + 1;
			books.push(book);
			return book;
		}

		function listCategories() {
			return categories;
		}

		return {
			books: {
				list: listBooks,
				add: addBook
			},
			categories: {
				list: listCategories
			}
		};
	} ());
	return library;
}
module.exports = solve;
