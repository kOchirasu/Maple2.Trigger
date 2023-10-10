using Maple2.Trigger.Enum;

namespace Maple2.Trigger._99999985_plantest_08 {
    public static class _ia_105 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(message: "환경음 테스트 트리거 입니다. 환경음을 켭니다. (HeavyRain)");
                context.SetSound(triggerId: 10001, enabled: true);
                context.Weather(type: WeatherType.HeavyRain);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateInteractObject(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInteractObject : TriggerState {
            internal StateInteractObject(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(message: "환경음이 꺼집니다.");
                context.SetSound(triggerId: 10001, enabled: false);
                context.Weather(type: WeatherType.None);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
