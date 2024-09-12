import { useState } from "react"

function Home() {

    const [count, setCount] = useState(0)


    return(
        <>
         <h1> Home </h1>

        <button className="btn btn-primary"  onClick={ () => setCount(count + 1)}>{ count }</button>

        </>
    )
}

export default Home