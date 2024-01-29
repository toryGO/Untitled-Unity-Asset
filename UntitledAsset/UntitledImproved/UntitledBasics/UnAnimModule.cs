// IN PROGRESS
using UnityEngine;


namespace UntitledAsset.Basics
{
    [System.Serializable]
	public class UnAnimModule
	{
        internal Sprite[] spriteFrames;
        
        internal int currentFrame;
        
        internal float currentTime;
        internal float timeBetweenFrames;
        
        internal bool IsPlaying;
        internal bool IsPaused;
        
        internal void Play(SpriteRenderer target)
        {
            if (IsPaused) return;

            IsPlaying = !IsPaused;

            currentTime += Time.deltaTime;

            if (currentTime >= timeBetweenFrames)
            {
                currentFrame = 0;
                target.sprite = spriteFrames[currentFrame];
                currentFrame++;

                if (currentFrame >= spriteFrames.Length)
                {
                    currentFrame = 0;
                }
            }
        }
        
        internal void Pause() => IsPaused = true;
        
        internal void Continue() => IsPaused = false;
        
        public void Stop()
        {
            currentFrame = 0;
            Pause();
        }
	}
}

