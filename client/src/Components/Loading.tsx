import {Spin} from "antd"

const Loading = () => {
    return (
        <div className="loading">
            <Spin size="large" tip="loading..."/>
        </div>
    )
}

export default Loading;