namespace Maple2.Trigger._99999985_plantest_08 {
    public static class _ia_105 {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(arg1: "환경음 테스트 트리거 입니다. 환경음을 켭니다. (HeavyRain)");
                context.SetSound(arg1: 10001, arg2: true);
                context.Weather(weatherType: "HeavyRain");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State오브젝트반응(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오브젝트반응 : TriggerState {
            internal State오브젝트반응(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(arg1: "환경음이 꺼집니다.");
                context.SetSound(arg1: 10001, arg2: false);
                context.Weather(weatherType: "None");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}