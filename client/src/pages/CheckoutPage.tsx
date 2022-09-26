
import { Elements } from '@stripe/react-stripe-js';
import { loadStripe } from '@stripe/stripe-js';
import { useEffect } from 'react';
import agent from '../actions/agent';
import Checkout from '../Components/Checkout';
import { setBasket } from '../redux/slice/basketSlice';
import { useAppDispatch } from '../redux/store/configureStore';

const stripePromise = loadStripe(
  'pk_test_51LlwtyLJ1eiUw1YvzIHJvU1b7VNGC8NVaI05XVaoPq6WaEykrGjkLe6I8sr9bs3Quu7pfi2uXM0ZV2ewKKds9Bu800nz6kDw7E');

  export default function CheckoutWrapper() {
    const dispatch = useAppDispatch();
  
    useEffect(() => {
      agent.Payments.paymentIntent()
        .then((basket) => dispatch(setBasket(basket)))
        .catch((error) => console.log(error));
    }, [dispatch]);
 
  return (
    <Elements stripe={stripePromise}>
      <Checkout />
    </Elements>
  );
}