import React from 'react';
import Post from './Posts'; // Import the Post component

class Posts extends React.Component {
  constructor(props) {
    super(props);
    // Initial state
    this.state = {
      posts: [],        // To store fetched posts
      hasError: false   // For error handling
    };
  }

  // Method to load posts from API
  loadPosts() {
    fetch('https://jsonplaceholder.typicode.com/posts')
      .then(response => response.json())
      .then(data => this.setState({ posts: data }))
      .catch(error => {
        console.error("Error fetching posts:", error);
        this.setState({ hasError: true });
      });
  }

  // Called once when component is mounted
  componentDidMount() {
    this.loadPosts();
  }

  // Called if an error is thrown in rendering or lifecycle
  componentDidCatch(error, info) {
    alert("An error occurred in Posts component");
    this.setState({ hasError: true });
  }

  // Render the list of posts using Post component
  render() {
    if (this.state.hasError) {
      return <h2>Something went wrong!</h2>;
    }

    return (
      <div>
        <h1>Blog Posts</h1>
        {this.state.posts.map(post => (
          <Post key={post.id} title={post.title} body={post.body} />
        ))}
      </div>
    );
  }
}

export default Posts;
