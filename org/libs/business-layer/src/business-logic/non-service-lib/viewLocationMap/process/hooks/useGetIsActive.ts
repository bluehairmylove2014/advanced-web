import { useViewLocationMapContext } from '../context';
import { useMemo } from 'react';

export const useGetIsActive = (): boolean => {
  const { state } = useViewLocationMapContext();
  return useMemo(() => state.isActive, [state.isActive]);
};
