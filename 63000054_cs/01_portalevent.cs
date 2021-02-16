using Maple2.Trigger.Enum;

namespace Maple2.Trigger._63000054_cs {
    public static class _01_portalevent {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 20007001, visible: false, enabled: false, minimapVisible: true);
                context.SetPortal(portalId: 20023001, visible: false, enabled: false, minimapVisible: true);
                context.CreateWidget(type: WidgetType.ReverseRaidPortal);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}