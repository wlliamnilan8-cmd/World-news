:root{
  --bg-1:#060710; --bg-2:#0f1330;
  --glass: rgba(255,255,255,0.04);
  --glass-2: rgba(255,255,255,0.06);
  --accent-a:#33c3ff; --accent-b:#8A4CFF;
  --muted:#b7c8e6;
  --card-border: rgba(138,76,255,0.12);
}

/* ========== BASE ========== */
*{box-sizing:border-box}
html,body{height:100%}
body{
  margin:0;
  font-family: "Inter", system-ui, -apple-system, "Segoe UI", Roboto, "Helvetica Neue", Arial;
  color: #e8f4ff;
  background:
    radial-gradient(900px 400px at 10% 10%, rgba(51,195,255,0.03), transparent 10%),
    linear-gradient(180deg,var(--bg-1),var(--bg-2));
  -webkit-font-smoothing:antialiased;
  -moz-osx-font-smoothing:grayscale;
}

/* ========== HEADER ========== */
.site-header{
  position:sticky; top:0; z-index:60;
  backdrop-filter: blur(10px) saturate(130%);
  background: linear-gradient(180deg, rgba(10,12,20,0.6), rgba(10,12,20,0.35));
  border-bottom: 1px solid rgba(255,255,255,0.02);
}
.header-inner{
  max-width:1200px; margin:0 auto; padding:14px 18px;
  display:flex; align-items:center; justify-content:space-between; gap:18px;
}
.brand{display:flex; gap:12px; align-items:center}
.logo{
  width:56px; height:56px; border-radius:12px;
  padding:6px; background: linear-gradient(180deg, rgba(255,255,255,0.03), rgba(255,255,255,0.01));
  box-shadow: 0 8px 30px rgba(10,10,30,0.6);
}
.title{
  font-weight:800; font-size:18px; letter-spacing:1px;
  background: linear-gradient(90deg,var(--accent-a),var(--accent-b));
  -webkit-background-clip:text; color:transparent;
}

/* ========== NAV ========== */
.main-nav{display:flex; gap:8px; align-items:center}
.nav-link{
  color:var(--muted); text-decoration:none; font-weight:700; font-size:13px;
  padding:8px 12px; border-radius:10px; transition:all .16s;
  background:transparent; border:1px solid rgba(255,255,255,0.02);
}
.nav-link:hover{ transform:translateY(-3px); color:#fff; background: linear-gradient(90deg, rgba(51,195,255,0.06), rgba(138,76,255,0.04)); box-shadow:0 8px 30px rgba(58,183,255,0.03) }
.nav-link.active{ color:#fff; background:linear-gradient(90deg,var(--accent-a),var(--accent-b)); box-shadow:0 12px 40px rgba(138,76,255,0.10) }

/* ========== LAYOUT ========== */
.container{ max-width:1200px; margin:28px auto; padding:0 16px 60px; }
.top-warning{ display:block; padding:10px; background:linear-gradient(90deg, rgba(138,76,255,0.08), rgba(51,195,255,0.04)); border-radius:8px; margin-bottom:12px; color:#e7f6ff }

/* HERO */
.hero{
  width:100%; border-radius:14px; overflow:hidden; position:relative; height:420px;
  margin-bottom:20px; border:1px solid rgba(255,255,255,0.03);
  box-shadow: 0 20px 60px rgba(10,12,30,0.6);
  background: linear-gradient(180deg, rgba(255,255,255,0.02), rgba(255,255,255,0.01));
}
.hero-img{ width:100%; height:100%; object-fit:cover; display:block; filter:brightness(.55); transition: transform .6s ease; }
.hero:hover .hero-img{ transform:scale(1.02) }
.hero-overlay{ position:absolute; left:40px; bottom:36px; color:#e9f6ff; max-width:62% }
.hero-category{ font-size:13px; color:var(--muted); margin-bottom:8px }
.hero-title{ font-size:34px; line-height:1.03; margin:0 0 12px; font-weight:800; text-shadow:0 6px 24px rgba(58,183,255,0.03); }
.hero-desc{ color:rgba(230,245,255,0.95); font-size:16px; max-height:5.0em; overflow:hidden; text-overflow:ellipsis }

/* GRID */
.grid{ display:grid; gap:18px; grid-template-columns: 1fr 340px; align-items:start; }
.left-column{ display:grid; gap:18px; grid-template-columns: repeat(auto-fit, minmax(260px,1fr)); }
.sidebar{ padding:12px; display:flex; flex-direction:column; gap:12px; }
.side-block{ background:var(--glass); padding:12px; border-radius:12px; border:1px solid rgba(255,255,255,0.02); }

/* ========== CARD (Glass) ========== */
.card{
  background: linear-gradient(180deg, rgba(255,255,255,0.02), rgba(255,255,255,0.01));
  border-radius:14px; overflow:hidden; border:1px solid var(--card-border);
  transition: transform .26s ease, box-shadow .26s ease;
  backdrop-filter: blur(10px) saturate(120%);
}
.card:hover{ transform:translateY(-8px); box-shadow: 0 30px 80px rgba(10,12,30,0.6); }
.card-img-wrap{ width:100%; height:170px; overflow:hidden; background: linear-gradient(90deg, rgba(0,0,0,0.12), transparent);}
.card-img{ width:100%; height:100%; object-fit:cover; display:block; transition: transform .4s ease; }
.card-img:hover{ transform: scale(1.06); }
.card-body{ padding:14px; }
.card-title{ font-size:16px; font-weight:800; color:#eaf8ff; margin-bottom:8px; }
.card-excerpt{ color:var(--muted); font-size:14px; line-height:1.45; margin-bottom:10px; }
.card-meta{ font-size:12px; color:rgba(200,220,255,0.6); display:flex; gap:10px; align-items:center; }

/* PILLS / CATEGORIES */
.pills{ display:flex; gap:8px; flex-wrap:wrap; margin:6px 0 14px; }
.pill{ padding:6px 10px; border-radius:999px; background:rgba(255,255,255,0.03); color:var(--muted); cursor:pointer; font-weight:700; border:1px solid rgba(255,255,255,0.02) }
.pill.active{ background:linear-gradient(90deg,var(--accent-a),var(--accent-b)); color:#fff; box-shadow:0 12px 40px rgba(138,76,255,0.08) }

/* FOOTER */
.site-footer{ text-align:center; padding:26px 12px; color:#93a6d6; border-top:1px solid rgba(255,255,255,0.02); margin-top:26px }

/* RESPONSIVO */
@media (max-width:980px){
  .grid{ grid-template-columns: 1fr; padding:0 6px; }
  .hero{ height:260px }
  .hero-overlay{ left:18px; bottom:18px; max-width:86% }
  .hero-title{ font-size:22px }
}
