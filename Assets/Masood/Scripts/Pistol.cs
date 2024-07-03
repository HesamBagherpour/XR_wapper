using UnityEngine;

public class Pistol : Gun
{
    [SerializeField] private float _durationBetweenShoot = .2f;
    [SerializeField] private bool _readyToShoot;
    private float _lastShootTime;

    public override void DoAction()
    {
        _lastShootTime = Time.time;
        if (!_readyToShoot)
            return;
        Shoot();
        _readyToShoot = false;
    }

    protected override void Initialize()
    {
        GunType = GunType.Pistol;
    }



    private void Update()
    {
        //if (Input.GetKey(KeyCode.A))
            //DoAction();
        if (Time.time > _lastShootTime + _durationBetweenShoot)
            _readyToShoot = true;
    }
}

